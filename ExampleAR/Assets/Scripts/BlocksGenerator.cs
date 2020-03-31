using UnityEngine;
using UnityEngine.UI;

public class BlocksGenerator : MonoBehaviour
{

    public VerticalLayoutGroup vlg;

    CodePanelController cpc;

    UIController uicontroller;


    //prefabs
    public GameObject blankLine;
    public GameObject class_head;
    public GameObject class_end;

    public GameObject main_function_head;
    public GameObject main_function_end;

    public GameObject function_head;
    public GameObject function_end;

    public GameObject function_call;

    public GameObject while_head;
    public GameObject while_end;
    public GameObject for_head;
    public GameObject for_end;

    public GameObject if_head;
    public GameObject if_end;
    public GameObject else_if_head;
    public GameObject else_if_end;
    public GameObject else_head;
    public GameObject else_end;

    public GameObject declare_int;
    public GameObject declare_string;
    public GameObject declare_float;

    public GameObject turnleft;
    public GameObject turnright;
    public GameObject step;


    //Coonditions
    public GameObject true_cond;
    public GameObject false_cond;

    //Comparison
    public GameObject equals;
    public GameObject not_equal;
    public GameObject greater;
    public GameObject less;
    public GameObject greater_equal;
    public GameObject less_equal;
    public GameObject and;
    public GameObject or;

    //variables
    public GameObject variable_block_template_int;
    public GameObject variable_block_template_string;
    public GameObject variable_block_template_float;

    //variable assignment
    public GameObject assignment;

    //Operations
    public GameObject addition;
    public GameObject subtraction;
    public GameObject multiplication;
    public GameObject division;

    //variable declaration
    GameObject declare_var;
    int new_scope = 0;




    // Use this for initialization
    void Start()
    {
        cpc = GetComponent<CodePanelController>();
        uicontroller = FindObjectOfType<UIController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void insertBlock(int index, BlockType type, float offset, int scope)
    {
        new_scope = scope;

        switch (type)
        {
            case BlockType.CLASS:

                addElement(Instantiate(class_head), index, offset, scope);
                addElement(Instantiate(blankLine), index + 1, offset + cpc.offset, scope);
                addElement(Instantiate(class_end), index + 2, offset, scope);
                addElement(Instantiate(blankLine), index + 3, offset, scope);
                

                break;

            case BlockType.MAIN_FUNCTION:

                addElement(Instantiate(blankLine), index , offset, scope);
                addElement(Instantiate(main_function_head), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(main_function_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);
                
                break;

            case BlockType.FUNCTION:

                addElement(Instantiate(blankLine),      index,      offset,                 scope);
                addElement(Instantiate(function_head),  index + 1,  offset,                 scope);
                addElement(Instantiate(blankLine),      index + 2,  offset + cpc.offset,    scope);
                addElement(Instantiate(function_end),   index + 3,  offset,                 scope);
                addElement(Instantiate(blankLine),      index + 4,  offset,                 scope);
                    
                break;

            case
            BlockType.FUNCTION_CALL:
                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(function_call), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);
                break;

            case BlockType.WHILE:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(while_head), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(while_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);

                break;
            case BlockType.FOR:

                declare_var = Instantiate(for_head);
                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(declare_var, index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(for_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);

                declare_var.transform.GetChild(0).GetChild(5).GetChild(0).GetChild(0).GetComponent<Block>().scope = scope;

                uicontroller.showPopUp();
                break;

            case BlockType.IF:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(if_head), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(if_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);
                
                break;
            case BlockType.ELSE_IF:

                addElement(Instantiate(else_if_head), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(else_if_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);

                break;
            case BlockType.ELSE:

                addElement(Instantiate(else_head), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset + cpc.offset, scope);
                addElement(Instantiate(else_end), index + 3, offset, scope);
                addElement(Instantiate(blankLine), index + 4, offset, scope);

                break;

            case BlockType.ASSIGNMENT:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(assignment), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);

                break;

            case BlockType.DECLARE_INT:

                declare_var = Instantiate(declare_int);

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(declare_var, index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);

                
                
                uicontroller.showPopUp();

                break;
            case BlockType.DECLARE_STRING:

                declare_var = Instantiate(declare_string);

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(declare_var, index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);



                uicontroller.showPopUp();

                break;

            case BlockType.DECLARE_FLOAT:

                declare_var = Instantiate(declare_float);

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(declare_var, index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);



                uicontroller.showPopUp();

                break;

            case BlockType.TURN_LEFT:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(turnleft), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);

                break;

            case BlockType.TURN_RIGHT:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(turnright), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);

                break;

            case BlockType.STEP:

                addElement(Instantiate(blankLine), index, offset, scope);
                addElement(Instantiate(step), index + 1, offset, scope);
                addElement(Instantiate(blankLine), index + 2, offset, scope);

                break;

            default:
                Debug.LogError("Block type not defined!");
                break;
        }

    }

    public void insertCondition(BlockType type, ConditionGap gap, int scope)
    {
        //this value is only temporary so its not null
        GameObject cond = this.gameObject;

        disableFitters(gap.gameObject);

        switch (type)
        {
            case BlockType.TRUE:
                cond = Instantiate(true_cond);
                break;
            case BlockType.FALSE:
                cond = Instantiate(false_cond);
                break;
            case BlockType.EQUALS:
                cond = Instantiate(equals);
                break;
            case BlockType.NOT_EQUAL:
                cond = Instantiate(not_equal);
                break;
            case BlockType.GREATER_THAN:
                cond = Instantiate(greater);
                break;
            case BlockType.LESS_THAN:
                cond = Instantiate(less);
                break;
            case BlockType.GREATER_EQUAL_THAN:
                cond = Instantiate(greater_equal);
                break;
            case BlockType.LESS_EQUAL_THAN:
                cond = Instantiate(less_equal);
                break;
            case BlockType.AND:
                cond = Instantiate(and);
                break;
            case BlockType.OR:
                cond = Instantiate(or);
                break;
        }

        if(cond.GetComponent<Block>() != null)
            cond.GetComponent<Block>().scope = scope;

        gap.resize(cond.GetComponent<RectTransform>().rect.width);
        cond.transform.SetParent(gap.transform);
        cond.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);

        cond.transform.localScale = new Vector2(1, 1);

        enableFitters(gap.gameObject);
    }

    public void insertVariable(VariableGap gap, Block block, string name, ValueType type)
    {
      
        disableFitters(gap.gameObject);

        GameObject go = new GameObject();

        switch (type)
        {
            case ValueType.INT:
                go = Instantiate(variable_block_template_int);
                break;
            case ValueType.STRING:
                go = Instantiate(variable_block_template_string);
                break;
            case ValueType.FLOAT:
                go = Instantiate(variable_block_template_float);
                break;
        }
        go.GetComponentInChildren<Text>().text = name;
        go.transform.SetParent(gap.transform);
        go.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);

        go.transform.localScale = new Vector2(1, 1);

       

        enableFitters(gap.gameObject);
    }

    public void insertOperation(GameObject gap, BlockType type, int scope)
    {
       
        disableFitters(gap);

        GameObject go = new GameObject();
        switch (type) {
            case BlockType.SUM:
                go = Instantiate(addition);
                break;
            case BlockType.SUBS:
                go = Instantiate(subtraction);
                break;
            case BlockType.MULT:
                go = Instantiate(multiplication);
                break;
            case BlockType.DIV:
                go = Instantiate(division);
                break;
        }
        
        go.transform.SetParent(gap.transform);
        go.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        go.GetComponent<Block>().scope = scope;

        go.transform.localScale = new Vector2(1, 1);

        enableFitters(gap);
    }

    public void setNewVarName(string text)
    {

        if (cpc.variableNameExists(text))
        {
            uicontroller.showPopUp();
            ToastMessage.showToastOnUiThread("Ya existe una variable con este nombre.");
            return;
        }

        disableFitters(declare_var.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).gameObject);

        Text txt = declare_var.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>();
        txt.text = text;

        enableFitters(declare_var.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).gameObject);

        if (declare_var.GetComponent<Block>().type == BlockType.FOR)
        {
            disableFitters(declare_var.transform.GetChild(0).GetChild(7).GetComponentInChildren<Text>().gameObject);
            txt = declare_var.transform.GetChild(0).GetChild(7).GetComponentInChildren<Text>();
            txt.text = text;
            enableFitters(declare_var.transform.GetChild(0).GetChild(7).GetComponentInChildren<Text>().gameObject);

            disableFitters(declare_var.transform.GetChild(0).GetChild(5).GetComponentInChildren<ValueGap>().GetComponentInChildren<Block>().GetComponentInChildren<Text>().gameObject);
            txt = declare_var.transform.GetChild(0).GetChild(5).GetComponentInChildren<ValueGap>().GetComponentInChildren<Block>().GetComponentInChildren<Text>();
            txt.text = text;
            enableFitters(declare_var.transform.GetChild(0).GetChild(5).GetComponentInChildren<ValueGap>().GetComponentInChildren<Block>().GetComponentInChildren<Text>().gameObject);
        }
               


        //finally we tell the code controller to add the variable to its dictionary
        switch (declare_var.GetComponent<Block>().type)
        {
            case BlockType.FOR:
                cpc.addIntVar(new Variable<int>(text, 0, new_scope + 1, declare_var.transform.GetSiblingIndex()));
                break;
            case BlockType.DECLARE_INT:
                cpc.addIntVar(new Variable<int>(text, 0, new_scope, declare_var.transform.GetSiblingIndex()));
                break;
            case BlockType.DECLARE_STRING:
                cpc.addStringVar(new Variable<string>(text, "", new_scope, declare_var.transform.GetSiblingIndex()));
                break;
            case BlockType.DECLARE_FLOAT:
                cpc.addFloatVar(new Variable<float>(text, 0.0f, new_scope, declare_var.transform.GetSiblingIndex()));
                break;
        }
    }

    public static void disableFitters(GameObject obj)
    {
        while (obj.tag != "Content")
        {
            if (obj.GetComponent<HorizontalLayoutGroup>() != null)
                obj.GetComponent<HorizontalLayoutGroup>().enabled = false;

            if (obj.GetComponent<ContentSizeFitter>() != null)
                obj.GetComponent<ContentSizeFitter>().enabled = false;

            obj = obj.transform.parent.gameObject;

        }
    }

    public static void enableFitters(GameObject obj)
    {
        Canvas.ForceUpdateCanvases();

        while (obj.tag != "Content"  && obj != null)
        {
            if (obj.GetComponent<HorizontalLayoutGroup>() != null)
                obj.GetComponent<HorizontalLayoutGroup>().enabled = true;

            Canvas.ForceUpdateCanvases();

            if (obj.GetComponent<ContentSizeFitter>() != null)
                obj.GetComponent<ContentSizeFitter>().enabled = true;

            Canvas.ForceUpdateCanvases();

            obj = obj.transform.parent.gameObject;
        }
    }

    void addElement(GameObject obj, int index, float offset, int scope)
    {
        obj.transform.SetParent(vlg.transform);

        obj.transform.SetSiblingIndex(index);

        obj.transform.GetChild(0).GetComponent<RectTransform>().anchoredPosition = new Vector3(offset, 0, 0);

        if (obj.GetComponent<Block>() != null)
            obj.GetComponent<Block>().scope = scope;

        if(obj.GetComponent<BlankLine>() != null)
            obj.GetComponent<BlankLine>().cpc = cpc;

        obj.transform.localScale = new Vector2(1, 1);
    }
}
