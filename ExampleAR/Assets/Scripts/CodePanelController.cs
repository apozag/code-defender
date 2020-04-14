using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variable<T>
{
    public T value;
    public string name;
    public int scope;
    public Block outerBlock;

    public Variable(string name, T value, int scope, Block outerBlock)
    {
        this.name = name;
        this.value = value;
        this.scope = scope;
        if (outerBlock != null)
            this.outerBlock = outerBlock;
    }

    public int getDeclaredLine()
    {
        return outerBlock.transform.GetSiblingIndex();
    }

}

public class Array<T>
{
    public List<T> values;
    public int size;
    public string name;
    public int scope;
    [SerializeField] public Block outerBlock;

    public Array(string name, int size, int scope, Block outerBlock)
    {
        this.name = name;
        this.size = size;
        this.scope = scope;
        if (outerBlock != null)
            this.outerBlock = outerBlock;
        this.values = new List<T>();
    }

    public int getDeclaredLine()
    {
        return outerBlock.transform.GetSiblingIndex();
    }
}

public enum ValueType
{
    INT,
    STRING,
    FLOAT
}

public class CodePanelController : MonoBehaviour
{

    public VerticalLayoutGroup vlg;

    BlocksGenerator bg;
    PaletteController pc;

    List<Block> blocks;

    Stack<BlockType> blockStack;

    static Dictionary<BlockType, int> hierarchyLevels = new Dictionary<BlockType, int>() {
        {BlockType.CLASS, 0 },
        {BlockType.FUNCTION, 1 },
        {BlockType.MAIN_FUNCTION, 1 },
        {BlockType.FUNCTION_CALL, 2 },
        {BlockType.STEP, 2 },
        {BlockType.TURN_LEFT, 2 },
        {BlockType.TURN_RIGHT, 2 },
        {BlockType.SAY, 2 },
        {BlockType.WHILE, 2 },
        {BlockType.FOR, 2 },
        {BlockType.DO_WHILE, 2 },
        {BlockType.IF, 2 },
        {BlockType.ELSE_IF, 2 },
        {BlockType.ELSE, 2 },
        {BlockType.ASSIGNMENT, 2 },
        {BlockType.DECLARE_INT, 3 },
        {BlockType.DECLARE_STRING,3 },
        {BlockType.DECLARE_FLOAT, 3 },
        {BlockType.DECLARE_INT_ARRAY, 3 }
    };

    public float offset = 50.0f;

    Block selectedBlock;

    //Para asegurarnos de que sólo hay una función de cada tipo
    //Cutre pero no se me ocurre otra manera
    bool hasMainMethod = false;
    bool hasAuxMethod = false;
    //Solo hay una clase
    bool hasClass = false;

    // Para asegurarnos de que no se pone el mismo bloque a la vez en dos espacios en blanco
    bool insertLock = false;


    //Variables
    Dictionary<string, Variable<int>> int_variables;
    Dictionary<string, Variable<string>> string_variables;
    Dictionary<string, Variable<float>> float_variables;

    Dictionary<string, Array<int>> int_arrays;

    // Use this for initialization
    void Start()
    {

        blocks = new List<Block>();
        blockStack = new Stack<BlockType>();

        int_variables = new Dictionary<string, Variable<int>>();
        string_variables = new Dictionary<string, Variable<string>>();
        float_variables = new Dictionary<string, Variable<float>>();

        int_arrays = new Dictionary<string, Array<int>>();

        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");

        foreach (Variable<string> var in VariablesLoadHelper.getStringVariables(topic + level))
            addStringVar(var);
        foreach (Variable<int> var in VariablesLoadHelper.getIntVariables(topic + level))
            addIntVar(var);
        foreach (Variable<float> var in VariablesLoadHelper.getFloatVariables(topic + level))
            addFloatVar(var);

        bg = GetComponent<BlocksGenerator>();
        pc = FindObjectOfType<PaletteController>();

        refreshHorizontalLayouts(vlg.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        insertLock = false;
    }

    public bool tryInsert(BlockType type, int index)
    {
        bool found = false;

        if (!insertLock)
        {

            insertLock = true;

            float newOffset = 0;

            int newScope = 0;

            //Nos aseguramos de que no ponemos dos funciones iguales
            if (type == BlockType.MAIN_FUNCTION && hasMainMethod)
            {
                ToastMessage.showToastOnUiThread("¡Sólo puede haber una función main!");
                return false;
            }
            else if (type == BlockType.FUNCTION && hasAuxMethod)
            {
                ToastMessage.showToastOnUiThread("¡No puede haber dos funciones con el mismo nombre!");
                return false;
            }

            for (int i = index; i >= 0; i--)
            {
                Block b = vlg.transform.GetChild(i).gameObject.GetComponent<Block>();
                if (b != null && b.hasEndBlock)
                {
                    if (!b.isHead())
                    {
                        blockStack.Push(b.type);
                    }
                    else
                    {
                        if (blockStack.Count > 0 && b.type == blockStack.Peek())
                        {
                            blockStack.Pop();
                        }
                        else if (hierarchyLevels[type] == 3 || hierarchyLevels[b.type] == hierarchyLevels[type] - 1 || (hierarchyLevels[b.type] == 2 && hierarchyLevels[type] == 2))
                        {
                            Block upper = vlg.transform.GetChild(index - 1).GetComponent<Block>();
                            //Si es un else if, debe de estar debajo de un if o un else if (su bloque de cierre)
                            if (type == BlockType.ELSE_IF &&
                                    ((upper != null && upper.type != BlockType.IF && upper.type != BlockType.ELSE_IF) ||
                                    upper.isHead()))
                            {
                                ToastMessage.showToastOnUiThread("Un 'else if' debe ir bajo un 'if' u otro 'else if'.");
                                return false;
                            }
                            //Si es un else, debe ir bajo un if o un else if (su bloque de cierre)
                            else if (type == BlockType.ELSE &&
                                    ((upper != null && upper.type != BlockType.IF && upper.type != BlockType.ELSE_IF) ||
                                    upper.isHead()))
                            {
                                ToastMessage.showToastOnUiThread("Un 'else' debe ir debajo de un 'else if' o un 'if'.");
                                return false;
                            }

                            //No puede haber métodos ni clases duplicados
                            if (type == BlockType.MAIN_FUNCTION)
                            {
                                if (hasMainMethod)
                                {
                                    ToastMessage.showToastOnUiThread("¡Sólo puede haber una función main!");
                                    return false;
                                }
                                else
                                {
                                    hasMainMethod = true;
                                }
                            }
                            else if (type == BlockType.FUNCTION)
                            {
                                if (hasAuxMethod)
                                {
                                    ToastMessage.showToastOnUiThread("¡No puede haber dos métodos iguales en la misma clase!");
                                    return false;
                                }
                                else
                                {
                                    hasAuxMethod = true;
                                }
                            }

                            //Yupi! todo en orden
                            found = true;
                            RectTransform rt = b.transform.GetChild(0).GetComponent<RectTransform>();
                            newOffset = offset + rt.anchoredPosition.x;
                            newScope = b.scope + 1;
                            break;
                        }
                        else
                            break;
                    }

                }
                if (i == 0 && type == BlockType.CLASS)
                {
                    if (hasClass)
                    {
                        ToastMessage.showToastOnUiThread("¡No puede haber dos clases iguales!");
                        return false;
                    }
                    else
                    {
                        hasClass = true;
                    }

                    found = true;

                }
            }

            if (found)
                bg.insertBlock(index, type, newOffset, newScope);
            else
                ToastMessage.showToastOnUiThread("No puedes colocar este bloque aqui.");

        }

        return found;
    }

    public bool tryInsertCondition(BlockType type, ConditionGap gap)
    {
        if (!insertLock)
        {
            insertLock = true;

            GameObject block = gap.gameObject;

            while (block.GetComponent<Block>() == null)
                block = block.transform.parent.gameObject;

            bg.insertCondition(type, gap, block.GetComponent<Block>().scope);

            return true;
        }
        return false;
    }

    public void selectBlock(Block b)
    {
        if (selectedBlock != null && b != selectedBlock)
            selectedBlock.GetComponent<ClickableBlock>().unselect();

        selectedBlock = b;
    }

    public void deleteSelected()
    {
        if (selectedBlock != null)
        {
            Stack<BlockType> blockStack = new Stack<BlockType>();

            bool found = false;

            bool finish = false;

            BlockType end = selectedBlock.type;

            int count = vlg.transform.childCount;
            if (selectedBlock.hasEndBlock)
            {
                for (int i = 0; i < 99; i++)
                {
                    Block b = vlg.transform.GetChild(i).GetComponent<Block>();
                    if (b != null)
                    {
                        if (!found)
                        {
                            if (b == selectedBlock)
                            {
                                //Destroy(vlg.transform.GetChild(b.transform.GetSiblingIndex() - 1).gameObject);
                                found = true;
                            }
                        }
                        else
                        {
                            if (b.head)
                            {
                                if (b.hasEndBlock)
                                    blockStack.Push(b.type);
                            }
                            else
                            {
                                if (blockStack.Count > 0)
                                {
                                    if (!b.head && b.type == blockStack.Peek())
                                        blockStack.Pop();
                                }
                                else
                                {
                                    if (b.type == end)
                                        finish = true;
                                }
                            }
                        }
                    }

                    if (found)
                    {
                        Destroy(vlg.transform.GetChild(i).gameObject);
                        count--;
                    }

                    if (finish)
                        break;
                }

                if (selectedBlock.type == BlockType.MAIN_FUNCTION)
                {
                    hasMainMethod = false;
                }
                else if (selectedBlock.type == BlockType.FUNCTION)
                {
                    hasAuxMethod = false;
                }
                else if (selectedBlock.type == BlockType.CLASS)
                {
                    hasMainMethod = false;
                    hasAuxMethod = false;
                    hasClass = false;
                }
                else if (selectedBlock.type == BlockType.FOR)
                {
                    deleteVariable(selectedBlock.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text);
                }

            }
            else
            {
                //Si el bloque está incrustado en otro:
                if (selectedBlock.inner)
                {
                    GameObject b = selectedBlock.transform.parent.gameObject;
                    while (b.GetComponent<Block>() == null)
                    {
                        if (b.GetComponent<VariableGap>() != null)
                        {
                            b.GetComponent<VariableGap>().reset();
                            return;
                        }
                        else if (b.GetComponent<ConditionGap>() != null)
                        {
                            b.GetComponent<ConditionGap>().reset();
                            return;
                        }

                        b = b.transform.parent.gameObject;
                    }
                    ToastMessage.showToastOnUiThread("¡Ups! Has encontrado un bug.");
                    return;
                }



                //Si el bloque eliminado es de declaración de variable, eliminamos la variable y todas sus referencias en el código
                if (selectedBlock.type == BlockType.DECLARE_INT ||
                    selectedBlock.type == BlockType.DECLARE_STRING ||
                    selectedBlock.type == BlockType.DECLARE_FLOAT)
                {
                    deleteVariable(selectedBlock.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text);
                }
                Destroy(selectedBlock.gameObject);
            }

            //Si el bloque de encima es un hueco en banco, también lo borramos
            if (vlg.transform.GetChild(selectedBlock.transform.GetSiblingIndex() - 1).GetComponent<Block>() == null)
                Destroy(vlg.transform.GetChild(selectedBlock.transform.GetSiblingIndex() - 1).gameObject);
        }
        else
            ToastMessage.showToastOnUiThread("Para eliminar un bloque, púlsalo para seleccionarlo antes.");
    }

    public bool tryInsertVariable(BlockType type, string name, VariableGap gap)
    {
        if (!insertLock)
        {
            insertLock = true;

            ValueType valType = getVariableType(name);

            GameObject block = gap.gameObject;

            while (block.GetComponent<Block>() == null)
            {
                block = block.transform.parent.gameObject;
            }



            //Previene de asignar una variable de un tipo a otro

            List<VariableGap> gaps = new List<VariableGap>();
            foreach (Transform child in block.transform.GetChild(0))
            {
                if (child.GetComponentInChildren<VariableGap>() != null)
                    gaps.Add(child.GetComponentInChildren<VariableGap>());
                else if (child.GetComponentInChildren<ValueGap>() != null)
                    gaps.Add(child.GetComponentInChildren<ValueGap>());
            }

            int i;
            if (gap.left)
                i = 1;
            else
                i = 0;

            if (gaps.Count > 1 && !gaps[i].empty)
            {
                foreach (Block b in gaps[i].GetComponentsInChildren<Block>())
                {
                    switch (b.type)
                    {
                        case BlockType.INT_VAR:
                            if (valType != ValueType.INT)
                            {
                                ToastMessage.showToastOnUiThread("No puedes asignar una variable a otra de distinto tipo.");
                                return false;
                            }
                            break;
                        case BlockType.STRING_VAR:
                            if (valType != ValueType.STRING)
                            {
                                ToastMessage.showToastOnUiThread("No puedes asignar una variable a otra de distinto tipo.");
                                return false;
                            }
                            break;
                        case BlockType.FLOAT_VAR:
                            if (valType != ValueType.FLOAT)
                            {
                                ToastMessage.showToastOnUiThread("No puedes asignar una variable a otra de distinto tipo.");
                                return false;
                            }
                            break;
                    }
                }
            }


            //Buscamos el bloque más externo (hijo del panel) para saber en qué línea está siendo usada la variable
            GameObject outerBlock = getOuterBlock(block);


            //Condiciones:  1- la variable no se usa antes de ser declarada
            //              2- la variable está definida en éste ámbito
            int siblingIndex = outerBlock.transform.GetSiblingIndex();
            int linedec = 0;
            int scopeblock = block.GetComponent<Block>().scope;
            int scopevar = 0;

            switch (valType)
            {
                case ValueType.INT:
                    if (type == BlockType.INT_ARRAY_VAR)
                    {
                        linedec = int_arrays[name].getDeclaredLine();
                        scopevar = int_arrays[name].scope;
                    }
                    else
                    {
                        linedec = int_variables[name].getDeclaredLine();
                        scopevar = int_variables[name].scope;
                    }
                    break;
                case ValueType.STRING:
                    linedec = string_variables[name].getDeclaredLine();
                    scopevar = string_variables[name].scope;
                    break;
                case ValueType.FLOAT:
                    linedec = float_variables[name].getDeclaredLine();
                    scopevar = float_variables[name].scope;
                    break;

            }

            //Padre que envuelve el scope de la variable
            Block parent = vlg.transform.GetChild(getParentLine(linedec)).GetComponent<Block>();

            //Comprobamos que se ha declarado antes de usarse
            if (siblingIndex > linedec &&
                scopeblock >= scopevar &&
                (linedec < 1 || isInSameScope(parent.id, siblingIndex, parent.type)))
            {

                bg.insertVariable(gap, type, name, valType);
                return true;

            }

            ToastMessage.showToastOnUiThread("¡La variable " + name + " no está definida en éste ámbito!");

        }
        return false;
    }

    public bool tryInsertOperation(BlockType type, VariableGap gap)
    {
        if (!insertLock)
        {
            GameObject block = gap.gameObject;

            while (block.GetComponent<Block>() == null)
            {
                block = block.transform.parent.gameObject;
            }

            bg.insertOperation(gap.gameObject, type, block.GetComponent<Block>().scope);

            insertLock = true;

            return true;
        }
        return false;
    }

    public void addIntVar(Variable<int> var)
    {
        int_variables.Add(var.name, var);
        if (pc != null)
            pc.refresh();
    }

    public void addStringVar(Variable<string> var)
    {
        string_variables.Add(var.name, var);
        if (pc != null)
            pc.refresh();
    }

    public void addFloatVar(Variable<float> var)
    {
        float_variables.Add(var.name, var);
        if (pc != null)
            pc.refresh();
    }

    public void addIntArray(Array<int> array)
    {
        int_arrays.Add(array.name, array);
        if (pc != null)
            pc.refresh();
    }

    public void editIntVar(string name, int val)
    {
        int_variables[name].value = val;
    }

    public void editStringVar(string name, string val)
    {
        string_variables[name].value = val;
    }

    public void editFloatVar(string name, float val)
    {
        float_variables[name].value = val;
    }

    public void editIntArray(string name, int position, int value)
    {
        int_arrays[name].values[position] = value;
    }

    public void setIntArraySize(string name, int size)
    {
        int_arrays[name].size = size;
        for (int i = 0; i < size; i++)
        {
            int_arrays[name].values.Add(0);
        }
    }

    public List<Variable<int>> getIntVariables()
    {
        return new List<Variable<int>>(int_variables.Values);
    }

    public List<Variable<string>> getStringVariables()
    {
        return new List<Variable<string>>(string_variables.Values);
    }

    public List<Variable<float>> getFloatVariables()
    {
        return new List<Variable<float>>(float_variables.Values);
    }

    public List<Array<int>> getIntArrays()
    {
        return new List<Array<int>>(int_arrays.Values);
    }


    public ValueType getVariableType(string name)
    {
        if (int_variables.ContainsKey(name))
            return ValueType.INT;
        else if (string_variables.ContainsKey(name))
            return ValueType.STRING;
        else if (float_variables.ContainsKey(name))
            return ValueType.FLOAT;
        else
            return ValueType.INT;
    }

    public int getIntValue(string name)
    {
        return int_variables[name].value;
    }

    public string getStringValue(string name)
    {
        return string_variables[name].value;
    }

    public float getFloatValue(string name)
    {
        return float_variables[name].value;
    }

    public int getIntArrayValue(string name, int position)
    {
        if (position >= int_arrays[name].values.Count)
        {
            return 0;
        }
        return int_arrays[name].values[position];
    }

    public bool checkIntArrayPosition(string name, int position)
    {
        return position < int_arrays[name].size;
    }

    public bool variableNameExists(string name)
    {
        return int_variables.ContainsKey(name) || string_variables.ContainsKey(name) || float_variables.ContainsKey(name);

    }


    public void deleteVariable(string name)
    {
        foreach (VariableGap gap in vlg.GetComponentsInChildren<VariableGap>())
        {
            if (gap.GetComponentInChildren<Image>() != null && gap.GetComponentInChildren<Image>().GetComponentInChildren<Text>().text == name)
            {
                gap.reset();
                Canvas.ForceUpdateCanvases();
            }
        }
        switch (getVariableType(name))
        {
            case ValueType.INT:
                int_variables.Remove(name);
                break;
            case ValueType.STRING:
                string_variables.Remove(name);
                break;
            case ValueType.FLOAT:
                float_variables.Remove(name);
                break;

        }
        pc.refresh();
        ToastMessage.showToastOnUiThread("Eliminada la variable " + name + ".");
    }

    public void refreshHorizontalLayouts(GameObject obj)
    {
        HorizontalLayoutGroup hlg = obj.GetComponent<HorizontalLayoutGroup>();
        ContentSizeFitter csf = obj.GetComponent<ContentSizeFitter>();

        if (hlg != null)
            hlg.enabled = false;


        if (csf != null)
            csf.enabled = false;


        foreach (Transform child in obj.transform)
            refreshHorizontalLayouts(child.gameObject);

        if (csf != null)
            csf.enabled = true;

        Canvas.ForceUpdateCanvases();

        if (hlg != null)
            hlg.enabled = true;

    }

    int getParentLine(int lineDeclared)
    {
        int index = lineDeclared;
        Block obj;

        while (index > 0)
        {
            obj = vlg.transform.GetChild(--index).GetComponent<Block>();
            if (obj != null && obj.isHead() && obj.hasEndBlock)
            {
                return obj.transform.GetSiblingIndex();
            }
        }
        return 0;
    }
    bool isInSameScope(int id, int line, BlockType typeParent)
    {
        int stackCount = 0;
        int index = line;
        Block block;
        while (index > 0)
        {
            block = vlg.transform.GetChild(--index).GetComponent<Block>();

            if (block != null && block.type == typeParent)
            {
                if (!block.isHead())
                {
                    stackCount++;
                }
                else if (stackCount > 0)
                {
                    stackCount--;
                }
                else if (block.id == id)
                {
                    return true;
                }
            }

        }
        return false;
    }

    GameObject getOuterBlock(GameObject obj)
    {
        while (obj.transform.parent.gameObject.tag != "Content")
        {
            obj = obj.transform.parent.gameObject;
        }
        return obj;
    }


}
