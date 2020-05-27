using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Interpreter : MonoBehaviour
{

    public GameObject vlg;

    public CommandsController cc;

    public CodePanelController cpc;

    public UIController uiController;

    public MessageChecker messageChecker;

    bool isExecuting = false;

    bool entryPointFound = false;

    //Conditional
    Stack<bool> conditionalLocks;

    //loops
    Stack<int> rollBackPos = new Stack<int>();
    Dictionary<int, int> iterations = new Dictionary<int, int>();

    //functions
    Stack<int> callIndices = new Stack<int>();
    Stack<int> returnValues = new Stack<int>();
    int callCount = 0;
    bool canDoRecursion;
    bool recursionUsed = false;
    bool functionCalled = false;
    bool mustCallFunction;

    //arguments
    Stack<int> arguments = new Stack<int>();

    Block current;

    int index = 0;

    string lang;
    string topicLevel;

    // Start is called before the first frame update
    void Start()
    {
        uiController = FindObjectOfType<UIController>();
        vlg = GameObject.FindGameObjectWithTag("Content");
        cpc = FindObjectOfType<CodePanelController>();
        messageChecker = uiController.GetComponent<MessageChecker>();
        
        conditionalLocks = new Stack<bool>();

        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");
        //Sólo podemos usar la recursión en el tema de la recursividad o modo entrenamiento
        canDoRecursion = (topic.Equals("6") || topic.Equals("99")) && !level.Equals("5") ;

        //Debemos usar la recursión en algunos niveles
        mustCallFunction = (topic.Equals("5") && int.Parse(level) >= 6 && int.Parse(level) <= 10) || topic.Equals("6");

        lang = PlayerPrefs.GetString("LANGUAGE");
        topicLevel = PlayerPrefs.GetString("TOPIC") + PlayerPrefs.GetString("LEVEL");        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc == null)
            cc = FindObjectOfType<CommandsController>();

    }

    public void execute()
    {
        if (cc == null || !cc.gameObject.activeSelf)
        {
            showErrorMessage(Localization.getString("TST_WAIT_APPEAR", lang));
            isExecuting = false;
        }
        else if (cc.isRunning())
        {
            showErrorMessage(Localization.getString("TST_WAIT_END", lang));
            isExecuting = false;
        }
        else
        {
            if (callCount == 0) {
                isExecuting = true;
                index = 0;
                entryPointFound = false;
                rollBackPos.Clear();
                iterations.Clear();
                conditionalLocks.Clear();
                callIndices.Clear();
                arguments.Clear();
                CDRandom.reset();
                callCount = 0;
            }

            while (isExecuting)
            {
                if (index < vlg.transform.childCount)
                {
                    if (vlg.transform.GetChild(index).GetComponent<Block>() != null)
                    {

                        current = vlg.transform.GetChild(index).GetComponent<Block>();

                        if (entryPointFound)
                        {
                            switch (current.type)
                            {
                                case BlockType.STEP:
                                    cc.addCommand(Command.STEP);
                                    break;
                                case BlockType.TURN_LEFT:
                                    cc.addCommand(Command.TURN_LEFT);
                                    break;
                                case BlockType.TURN_RIGHT:
                                    cc.addCommand(Command.TURN_RIGHT);
                                    break;
                                case BlockType.SAY:
                                    cc.addCommand(Command.TALK);
                                    string message = evaluateValueString(current.GetComponentInChildren<VariableGap>(), false, true);
                                    cc.addMessage(message);
                                    if(messageChecker != null)
                                        messageChecker.currentMessages.Add(message);
                                    break;
                                case BlockType.STEP_NUM:
                                    int number = evaluateValueInt(current.GetComponentInChildren<VariableGap>());
                                    if (number >= 0)
                                    {
                                        for (int i = 0; i < number; i++)
                                        {
                                            cc.addCommand(Command.STEP);
                                        }
                                    }
                                    else
                                    {
                                        showErrorMessage(Localization.getString("TST_NEGATIVE_VALUE", lang));
                                        stopExecution();
                                    }
                                    break;
                                case BlockType.IF:
                                    if (current.isHead())
                                    {
                                        if (evaluateCondition(current.GetComponentInChildren<ConditionGap>()))
                                        {
                                            conditionalLocks.Push(false);
                                        }
                                        else
                                        {
                                            skip(BlockType.IF);
                                            conditionalLocks.Push(true);
                                        }
                                    }
                                    break;
                                case BlockType.ELSE_IF:
                                    if (current.isHead())
                                    {
                                        if (conditionalLocks.Peek() && evaluateCondition(current.GetComponentInChildren<ConditionGap>()))
                                        {
                                            conditionalLocks.Pop();
                                            conditionalLocks.Push(false);
                                        }
                                        else
                                        {
                                            skip(BlockType.ELSE_IF);
                                        }
                                    }
                                    break;
                                case BlockType.ELSE:
                                    if (current.isHead())
                                    {
                                        if (conditionalLocks.Peek())
                                        {
                                            conditionalLocks.Pop();
                                        }
                                        else
                                        {
                                            skip(BlockType.ELSE);
                                        }
                                    }
                                    break;

                                case BlockType.FUNCTION_CALL:
                                    if(callCount > 0)
                                    {
                                        if (!canDoRecursion)
                                        {
                                            showErrorMessage(Localization.getString("TST_NO_RECURSION", lang));
                                            stopExecution();
                                        }
                                        else
                                        {
                                            recursionUsed = true;
                                        }
                                    }
                                    if (callCount > 30)
                                    {
                                        showErrorMessage(Localization.getString("TST_TOO_MANY_CALLS", lang));
                                        stopExecution();
                                    }
                                    callCount++;
                                    callIndices.Push(index);
                                    searchFunction(BlockType.FUNCTION);
                                    break;

                                case BlockType.FUNCTION_ARG_CALL:
                                    if (callCount > 0)
                                    {
                                        if (!canDoRecursion)
                                        {
                                            showErrorMessage(Localization.getString("TST_NO_RECURSION", lang));
                                            stopExecution();
                                        }
                                        else
                                        {
                                            recursionUsed = true;
                                        }
                                    }
                                    if (callCount > 30)
                                    {
                                        showErrorMessage(Localization.getString("TST_TOO_MANY_CALLS", lang));
                                        stopExecution();
                                    }

                                    functionCalled = true;

                                    arguments.Push(evaluateValueInt(current.GetComponentInChildren<VariableGap>()));
                                    cpc.editIntVar("param", arguments.Peek());

                                    callCount++;
                                    callIndices.Push(index);
                                    searchFunction(BlockType.FUNCTION_ARG);
                                    break;

                                case BlockType.RETURN:

                                    arguments.Pop();
                                    if (arguments.Count > 0)
                                        cpc.editIntVar("param", arguments.Peek());

                                    index = callIndices.Pop();
                                    returnValues.Push(evaluateValueInt(current.GetComponentInChildren<VariableGap>()));
                                    callCount--;
                                    return;

                                case BlockType.FUNCTION_RETURN:
                                    if (current.isHead())
                                    {
                                        skip(BlockType.FUNCTION_RETURN);
                                    }
                                    else
                                    {
                                        showErrorMessage(Localization.getString("TST_NO_RETURN", lang));
                                        stopExecution();
                                    }
                                    break;

                                case BlockType.FUNCTION_RETURN_CALL:
                                    if (callCount > 0)
                                    {
                                        if (!canDoRecursion)
                                        {
                                            showErrorMessage(Localization.getString("TST_NO_RECURSION", lang));
                                            stopExecution();
                                        }
                                        else
                                        {
                                            recursionUsed = true;
                                        }
                                    }
                                    if (callCount > 30)
                                    {
                                        showErrorMessage(Localization.getString("TST_TOO_MANY_CALLS", lang));
                                        stopExecution();
                                    }
                                    callCount++;
                                    executeReturnFunc(evaluateValueInt(current.GetComponentInChildren<VariableGap>()));
                                    break;

                                case BlockType.FUNCTION:
                                    if (current.isHead())
                                    {
                                        skip(BlockType.FUNCTION);
                                    }
                                    else
                                    {
                                        index = callIndices.Pop();
                                        callCount--;
                                    }
                                    break;

                                case BlockType.FUNCTION_ARG:
                                    if (current.isHead())
                                    {
                                        skip(BlockType.FUNCTION_ARG);
                                    }
                                    else
                                    {
                                        index = callIndices.Pop();
                                        arguments.Pop();
                                        if(arguments.Count > 0)
                                            cpc.editIntVar("param", arguments.Peek());
                                        callCount--;
                                    }
                                    break;


                                case BlockType.WHILE:
                                    if (current.isHead())
                                    {
                                        if (!evaluateCondition(current.GetComponentInChildren<ConditionGap>()))
                                        {
                                            skip(BlockType.WHILE);
                                            iterations.Remove(index);
                                        }
                                        else
                                        {
                                            rollBackPos.Push(index);

                                            if (iterations.ContainsKey(rollBackPos.Peek()))
                                                iterations[rollBackPos.Peek()]++;
                                            else
                                                iterations.Add(rollBackPos.Peek(), 0);

                                            //A partir de 30 iteraciones se interpreta como un bucle infinito y paramos la ejecución.
                                            //Más iteraciones pueden provocar el crasheo de la aplicación.
                                            if (iterations[rollBackPos.Peek()] > 30)
                                            {
                                                showErrorMessage("¡Has hecho un bucle infinito o con demasiadas iteraciones!");
                                                stopExecution();
                                            }
                                        }
                                    }
                                    else
                                        index = rollBackPos.Pop() - 1;
                                    break;
                                case BlockType.FOR:
                                    if (current.isHead())
                                    {
                                        if (!iterations.ContainsKey(index))
                                        {
                                            string varName = current.transform.GetChild(0).GetChild(1).GetComponentInChildren<VariableGap>().GetComponentInChildren<Text>().text;
                                            int value = evaluateValueInt(current.transform.GetChild(0).GetChild(3).GetComponentInChildren<ValueGap>());
                                            cpc.editIntVar(varName, value);
                                        }
                                        if (!evaluateCondition(current.GetComponentInChildren<ConditionGap>()))
                                        {
                                            iterations.Remove(index);
                                            skip(BlockType.FOR);
                                        }
                                        else
                                        {
                                            rollBackPos.Push(index);

                                            if (iterations.ContainsKey(rollBackPos.Peek()))
                                                iterations[rollBackPos.Peek()]++;
                                            else
                                                iterations.Add(rollBackPos.Peek(), 0);

                                            //A partir de 30 iteraciones se interpreta como un bucle infinito y paramos la ejecución.
                                            //Más iteraciones pueden provocar el crasheo de la aplicación.
                                            if (iterations[rollBackPos.Peek()] > 30)
                                            {
                                                showErrorMessage(Localization.getString("TST_INFINITE_LOOP", lang));
                                                stopExecution();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (rollBackPos.Count > 0)
                                        {
                                            index = rollBackPos.Pop() - 1;
                                            Transform obj = vlg.transform.GetChild(index + 1);
                                            obj = obj.GetChild(0).GetChild(1);
                                            VariableGap vg = obj.GetComponentInChildren<VariableGap>();
                                            string varName = vg.GetComponentInChildren<Text>().text;
                                            cpc.editIntVar(varName, cpc.getIntValue(varName) + 1);
                                        }
                                        else
                                        {
                                            showErrorMessage("Internal Error: plese report this error to adripoza23@gmail.com");
                                            stopExecution();
                                        }
                                    }
                                    break;
                                case BlockType.DO_WHILE:
                                    if (current.isHead())
                                    {
                                        rollBackPos.Push(index);

                                        if (iterations.ContainsKey(rollBackPos.Peek()))
                                            iterations[rollBackPos.Peek()]++;
                                        else
                                            iterations.Add(rollBackPos.Peek(), 0);

                                        //A partir de 30 iteraciones se interpreta como un bucle infinito y paramos la ejecución.
                                        //Más iteraciones pueden provocar el crasheo de la aplicación.
                                        if (iterations[rollBackPos.Peek()] > 30)
                                        {
                                            showErrorMessage(Localization.getString("TST_INFINITE_LOOP", lang));
                                            stopExecution();
                                        }
                                    }
                                    else
                                    {
                                        if (evaluateCondition(current.GetComponentInChildren<ConditionGap>()))
                                        {
                                            index = rollBackPos.Pop() - 1;
                                        }
                                    }
                                    break;
                                case BlockType.ASSIGNMENT:
                                    VariableGap gap = current.GetComponentInChildren<VariableGap>();
                                    Block block = gap.GetComponentInChildren<Block>();
                                    if (block != null && block.type == BlockType.INT_ARRAY_VAR)
                                    {
                                        int pos = evaluateValueInt(block.GetComponentInChildren<VariableGap>());
                                        string name = block.GetComponentInChildren<Text>().text;
                                        if (!cpc.checkIntArrayPosition(name, pos))
                                        {
                                            showErrorMessage(Localization.getString("TST_ARRAY_INDEX_OUT", lang));
                                            stopExecution();
                                        }
                                        else
                                        {
                                            cpc.editIntArray(name, pos, evaluateValueInt(current.transform.GetChild(0).GetChild(2).GetComponentInChildren<VariableGap>()));
                                        }
                                    }
                                    else
                                    {
                                        string nameA = gap.GetComponentInChildren<Text>().text;
                                        switch (cpc.getVariableType(nameA))
                                        {
                                            case ValueType.INT:
                                                int valueA = evaluateValueInt(current.GetComponentsInChildren<VariableGap>()[1]);
                                                cpc.editIntVar(nameA, valueA);
                                                break;
                                            case ValueType.STRING:
                                                string valueAS = evaluateValueString(current.GetComponentsInChildren<VariableGap>()[1], true, false);
                                                cpc.editStringVar(nameA, valueAS);
                                                break;
                                            case ValueType.FLOAT:
                                                float valueAF = evaluateValueFloat(current.GetComponentsInChildren<VariableGap>()[1]);
                                                cpc.editFloatVar(nameA, valueAF);
                                                break;
                                        }
                                    }

                                    break;
                                case BlockType.MAIN_FUNCTION:
                                    isExecuting = false;
                                    //No hay errores. Comienza la secuencia de movimientos
                                    uiController.scrollDown();
                                    //showErrorMessage("¡Hurra!¡No hay errores en el código!");
                                    callCount = 0;
                                    cc.start();
                                    break;
                            }
                        }
                        else
                        {
                            if (current.type == BlockType.MAIN_FUNCTION)
                                entryPointFound = true;
                        }

                        switch (current.type)
                        {
                            case BlockType.DECLARE_STATIC_INT:
                            case BlockType.DECLARE_INT:
                                string nameI = current.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text;
                                int valueI = evaluateValueInt(current.GetComponentInChildren<ValueGap>());
                                cpc.editIntVar(nameI, valueI);
                                cpc.setVariableScope(nameI, current);
                                break;
                            case BlockType.DECLARE_STATIC_STRING:
                            case BlockType.DECLARE_STRING:
                                string nameS = current.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text;
                                string valueS = evaluateValueString(current.GetComponentInChildren<ValueGap>(), true, false);
                                cpc.editStringVar(nameS, valueS);
                                cpc.setVariableScope(nameS, current);
                                break;
                            case BlockType.DECLARE_STATIC_FLOAT:
                            case BlockType.DECLARE_FLOAT:
                                string nameF = current.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text;
                                float valueF = evaluateValueFloat(current.GetComponentInChildren<ValueGap>());
                                cpc.editFloatVar(nameF, valueF);
                                cpc.setVariableScope(nameF, current);
                                break;
                            case BlockType.DECLARE_STATIC_INT_ARRAY:
                            case BlockType.DECLARE_INT_ARRAY:
                                string nameIA = current.transform.GetChild(0).GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text;
                                int size = evaluateValueInt(current.GetComponentInChildren<ValueGap>());
                                cpc.setIntArraySize(nameIA, size);
                                cpc.setArrayScope(nameIA, current);
                                break;
                        }

                    }
                    index++;
                }
                else
                {
                    stopExecution();
                    showErrorMessage(Localization.getString("TST_ENTRYPOINT_NOT_FOUND", lang));
                }
            }
        }
    }

    public void stopExecution()
    {
        cc.stop();
        isExecuting = false;
        callCount = 0;
    }

    public bool evaluateCondition(ConditionGap gap)
    {
        Block cond = gap.GetComponentInChildren<Block>();

        if (cond == null)
        {
            showErrorMessage(Localization.getString("TST_GAP_EMPTY", lang));
            showErrorMarker(gap.GetComponent<Image>());
            stopExecution();
            return false;
        }

        List<VariableGap> gaps = getGaps(cond.gameObject);
        string str = "";
        if (gaps.Count > 0)
            str = evaluateValueString(gaps[0], false, false);

        switch (cond.type)
        {
            case BlockType.EQUALS:

                if (IsStringValue(str))
                {
                    return str.Equals(evaluateValueString(gaps[1], true, false));
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) == evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    return false;
                }
            case BlockType.NOT_EQUAL:

                if (IsStringValue(str))
                {
                    return !str.Equals(evaluateValueString(gaps[1], true, false));
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) != evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }

            case BlockType.GREATER_THAN:

                if (IsStringValue(str))
                {
                    //Error: no se pueden comparar string con '>'
                    showErrorMessage(Localization.getString("TST_STRING_COMPARED_WITH", lang) + ">");
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) > evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }

            case BlockType.LESS_THAN:

                if (IsStringValue(str))
                {
                    //Error: No se pueden comparar string con '<'
                    showErrorMessage(Localization.getString("TST_STRING_COMPARED_WITH", lang) + "<");
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) < evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
            case BlockType.GREATER_EQUAL_THAN:

                if (IsStringValue(str))
                {
                    //Error: No se pueden comparar string con '>='
                    showErrorMessage(Localization.getString("TST_STRING_COMPARED_WITH", lang) + ">=");
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) >= evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    stopExecution();
                    return false;
                }
            case BlockType.LESS_EQUAL_THAN:
                if (IsStringValue(str))
                {
                    //Error: No se pueden comparar string con '>='
                    showErrorMessage(Localization.getString("TST_STRING_COMPARED_WITH", lang) + "<=");
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
                else if (IsDigitsOnly(str) || IsFloatValue(str))
                {
                    return evaluateValueInt(gaps[0]) <= evaluateValueInt(gaps[1]);
                }
                else
                {
                    //Error: entrada incorrecta.
                    showErrorMessage(Localization.getString("TST_INCORRECT_DATA", lang));
                    showErrorMarker(gaps[0].GetComponent<Image>());
                    stopExecution();
                    return false;
                }
            case BlockType.AND:
                List<ConditionGap> condGaps = getConditionGaps(cond.gameObject);
                if (condGaps.Count > 1)
                    return evaluateCondition(condGaps[0]) && evaluateCondition(condGaps[1]);
                else return false;
            case BlockType.OR:
                List<ConditionGap> condGaps1 = getConditionGaps(cond.gameObject);
                if (condGaps1.Count > 1)
                    return evaluateCondition(condGaps1[0]) || evaluateCondition(condGaps1[1]);
                else return false;
            case BlockType.TRUE:
                return true;
            case BlockType.FALSE:
                return false;
            default:
                //Error: Bloque no reconocido como condición.
                showErrorMessage("Internal Error: please report this error to adripoza23@gmail.com");
                stopExecution();
                return false;

        }

    }

    public int evaluateValueInt(VariableGap gap)
    {
        Block val = gap.GetComponentInChildren<Block>();
        if (val != null)
        {
            List<VariableGap> gaps = getGaps(val.gameObject);
            switch (val.type)
            {
                case BlockType.INT_VAR:
                    return cpc.getIntValue(val.GetComponentInChildren<Text>().text);
                case BlockType.INT_ARRAY_VAR:
                    int pos = evaluateValueInt(val.GetComponentInChildren<VariableGap>());
                    string name = val.GetComponentInChildren<Text>().text;
                    if (!cpc.checkIntArrayPosition(name, pos))
                    {
                        showErrorMessage(Localization.getString("TST_ARRAY_INDEX_OUT", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                    }
                    return cpc.getIntArrayValue(name, pos);
                case BlockType.SUM:
                    return evaluateValueInt(gaps[0]) + evaluateValueInt(gaps[1]);
                case BlockType.SUBS:
                    return evaluateValueInt(gaps[0]) - evaluateValueInt(gaps[1]);
                case BlockType.MULT:
                    return evaluateValueInt(gaps[0]) * evaluateValueInt(gaps[1]);
                case BlockType.DIV:
                    return evaluateValueInt(gaps[0]) / evaluateValueInt(gaps[1]);
                case BlockType.RANDOM:
                    return CDRandom.range(topicLevel, evaluateValueInt(gaps[0]), evaluateValueInt(gaps[1]));
                case BlockType.FUNCTION_RETURN_CALL:
                    return executeReturnFunc(evaluateValueInt(gaps[0]));
                default:
                    //Error: Tipo de dato no compatible con int
                    showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_INT", lang));
                    showErrorMarker(gap.GetComponentInChildren<Image>());
                    stopExecution();
                    return 0;
            }
        }
        else
        {
            InputField ip = gap.GetComponentInChildren<InputField>();
            string str = "";
            if (ip != null)
                str = ip.text;
            else
                str = gap.GetComponentInChildren<Text>().text;

            if (!str.Equals(""))
            {
                if (!IsDigitsOnly(str))
                {
                    //Error: este valor no es compatible con int
                    showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_INT", lang));
                    showErrorMarker(gap.GetComponent<Image>());
                    stopExecution();
                    return 0;
                }
                int value = int.Parse(str);
                return value;
            }
            else
            {
                showErrorMessage(Localization.getString("TST_GAP_EMPTY", lang));
                showErrorMarker(gap.GetComponent<Image>());
                stopExecution();
                return 0;
            }
        }
    }

    public string evaluateValueString(VariableGap gap, bool strict, bool stringify)
    {
        Block val = gap.GetComponentInChildren<Block>();
        if (val != null)
        {
            switch (val.type)
            {
                case BlockType.STRING_VAR:
                    return cpc.getStringValue(val.GetComponentInChildren<Text>().text);

                case BlockType.INT_VAR:
                    if (strict)
                    {
                        showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                        return "";
                    }else if (stringify)
                    {
                        return "\"" + cpc.getIntValue(val.GetComponentInChildren<Text>().text).ToString() + "\"";

                    }
                    return cpc.getIntValue(val.GetComponentInChildren<Text>().text).ToString();

                case BlockType.INT_ARRAY_VAR:
                    if (strict)
                    {
                        showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                        return "";
                    }
                    int pos = evaluateValueInt(val.GetComponentInChildren<VariableGap>());
                    string name = val.GetComponentInChildren<Text>().text;
                    if (!cpc.checkIntArrayPosition(name, pos))
                    {
                        showErrorMessage(Localization.getString("TST_ARRAY_INDEX_OUT", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                    }

                    if (stringify)
                    {
                        return "\"" + cpc.getIntArrayValue(name, pos).ToString() + "\"";
                    }
                    return cpc.getIntArrayValue(name, pos).ToString();

                case BlockType.FLOAT_VAR:
                    if (strict)
                    {
                        showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                        return "";
                    }
                    string str = cpc.getFloatValue(val.GetComponentInChildren<Text>().text).ToString();
                    if (!str.Contains(",") && !str.Contains("."))
                        str += ".0";
                    if (stringify)
                    {
                        str = "\"" + str + "\"";
                    }
                    return str;
                case BlockType.SUM:
                    List<VariableGap> gaps = getGaps(val.gameObject);
                    return stringConcatenate(evaluateValueString(gaps[0], true, false), evaluateValueString(gaps[1], false, true));
                case BlockType.SUBS:
                    //Error: no se pueden restar dos string
                    showErrorMessage(Localization.getString("TST_STRING_NOT_SUM", lang));
                    stopExecution();
                    return "";
                case BlockType.MULT:
                    //Error: no se pueden multiplicar dos string
                    showErrorMessage(Localization.getString("TST_STRING_NOT_MULT", lang));
                    stopExecution();
                    return "";
                case BlockType.DIV:
                    //Error: no se pueden dividir dos string
                    showErrorMessage(Localization.getString("TST_STRING_NOT_DIV", lang));
                    stopExecution();
                    return "";
                case BlockType.RANDOM:
                    showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                    stopExecution();
                    return "";
                case BlockType.FUNCTION_RETURN_CALL:
                    if (strict)
                    {
                        showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                        stopExecution();
                        return "";
                    }
                    string res = executeReturnFunc(evaluateValueInt(val.GetComponentInChildren<VariableGap>())).ToString();
                    if (stringify)
                    {
                        res = "\"" + res + "\"";
                    }
                    return res;
                default:
                    //Error: Tipo de dato no compatible con string
                    showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_STRING", lang));
                    showErrorMarker(gap.GetComponentInChildren<Image>());
                    stopExecution();
                    return "";
            }
        }
        else
        {

            InputField ip = gap.GetComponentInChildren<InputField>();
            string str = "";
            if (ip != null)
                str = ip.text;
            else
                str = gap.GetComponentInChildren<Text>().text;

            if (!str.Equals(""))
            {
                if (strict)
                {
                    if (!IsStringValue(str)){
                        //Error: Un valor de string debe ir entre comillas
                        showErrorMessage(Localization.getString("TST_STRING_QUOTE", lang));
                        showErrorMarker(gap.GetComponentInChildren<Image>());
                        stopExecution();
                    }
                }else if (stringify)
                {
                    str = "\"" + str + "\"";
                }
            }
            else
            {
                showErrorMessage(Localization.getString("TST_GAP_EMPTY", lang));
                showErrorMarker(gap.GetComponent<Image>());
                stopExecution();
            }
            return str;
        }
    }

    public float evaluateValueFloat(VariableGap gap)
    {
        Block val = gap.GetComponentInChildren<Block>();
        if (val != null)
        {
            List<VariableGap> gaps = getGaps(val.gameObject);
            switch (val.type)
            {
                case BlockType.FLOAT_VAR:
                    return cpc.getFloatValue(val.GetComponentInChildren<Text>().text);
                case BlockType.INT_VAR:
                    return cpc.getIntValue(val.GetComponentInChildren<Text>().text);
                case BlockType.INT_ARRAY_VAR:
                    int pos = evaluateValueInt(val.GetComponent<VariableGap>());
                    string name = val.GetComponentInChildren<Text>().text;
                    if (!cpc.checkIntArrayPosition(name, pos))
                    {
                        showErrorMessage(Localization.getString("TST_ARRAY_INDEX_OUT", lang));
                        showErrorMarker(gap.GetComponent<Image>());
                        stopExecution();
                    }
                    return cpc.getIntArrayValue(name, pos);
                case BlockType.SUM:
                    return evaluateValueFloat(gaps[0]) + evaluateValueFloat(gaps[1]);
                case BlockType.SUBS:
                    return evaluateValueFloat(gaps[0]) - evaluateValueFloat(gaps[1]);
                case BlockType.MULT:
                    return evaluateValueFloat(gaps[0]) * evaluateValueFloat(gaps[1]);
                case BlockType.DIV:
                    return evaluateValueFloat(gaps[0]) / evaluateValueFloat(gaps[1]);
                case BlockType.RANDOM:
                    return CDRandom.range(topicLevel, evaluateValueInt(gaps[0]), evaluateValueInt(gaps[1]));
                case BlockType.FUNCTION_RETURN_CALL:
                    return executeReturnFunc(evaluateValueInt(gaps[0]));
                default:
                    //Error: Tipo de dato no compatible con float
                    showErrorMessage("Tipo de dato no compatible con float.");
                    showErrorMarker(gap.GetComponentInChildren<Image>());
                    stopExecution();
                    return 0;
            }
        }
        else
        {
            InputField ip = gap.GetComponentInChildren<InputField>();
            string str = "";
            if (ip != null)
                str = ip.text;
            else if (gap.GetComponentInChildren<Text>() != null)
                str = gap.GetComponentInChildren<Text>().text;
            else
            {
                showErrorMessage("Internal Error: please report this error to adripoza23@gmail.com");
                showErrorMarker(gap.GetComponent<Image>());
            }

            if (!str.Equals(""))
            {
                if (!IsFloatValue(str))
                {
                    //Error: Valor no compatible con float
                    showErrorMessage(Localization.getString("TST_NOT_COMPATIBLE_FLOAT", lang));
                    showErrorMarker(gap.GetComponent<Image>());
                    stopExecution();
                }
            }
            else
            {
                showErrorMessage(Localization.getString("TST_GAP_EMPTY", lang));
                showErrorMarker(gap.GetComponent<Image>());
                stopExecution();
                return 0;
            }
            
            float res = float.Parse(str);

            //Dependiendo de algo raro, el float.Parse() va con '.' o ','
            //if(!str.Equals("" + res))
            //    res = float.Parse(str.Replace(".", ","));

            return res;
        }
    }

    int executeReturnFunc(int value)
    {
        if (callCount > 0)
        {
            if (!canDoRecursion)
            {
                showErrorMessage(Localization.getString("TST_NO_RECURSION", lang));
                stopExecution();
            }
            else
            {
                recursionUsed = true;
            }
        }
        if (callCount > 30)
        {
            showErrorMessage(Localization.getString("TST_TOO_MANY_CALLS", lang));
            stopExecution();
        }
        callCount++;
        callIndices.Push(index);
        searchFunction(BlockType.FUNCTION_RETURN);
        index++;
        functionCalled = true;
        arguments.Push(value);
        cpc.editIntVar("param", arguments.Peek());
        execute();
        return returnValues.Pop();
    }

    public void skip(BlockType type)
    {
        int stackCount = 0;
        bool done = false;
        while (!done)
        {
            index++;
            Block b = vlg.transform.GetChild(index).GetComponent<Block>();
            if (b != null)
            {
                if (b.type == type)
                {
                    if (b.isHead())
                    {
                        stackCount++;
                    }
                    else
                    {
                        if (stackCount <= 0)
                            done = true;
                        else
                            stackCount--;
                    }
                }
            }

        }
    }
    void searchFunction(BlockType type)
    {
        index = 0;
        
        foreach(Transform child in vlg.transform)
        {
            Block b = child.GetComponent<Block>();
            if(b != null && b.isHead() && b.type == type)
            {
                break;
            }
            index++;
        }
    }


    static bool IsDigitsOnly(string str)
    {
        str = str.TrimStart('-');
        foreach (char c in str)
        {
            if (c < '0' || c > '9')
                return false;
        }

        return true;
    }

    static bool IsStringValue(string str)
    {
        return str[0].Equals('"') && str[str.Length - 1].Equals('"');
    }

    static bool IsFloatValue(string str)
    {
        return IsDigitsOnly(str.Replace(",", string.Empty)) || IsDigitsOnly(str.Replace(".", string.Empty));
    }

    public List<VariableGap> getGaps(GameObject obj)
    {
        List<VariableGap> gaps = new List<VariableGap>();

        if (obj.GetComponent<Block>() != null && obj.GetComponent<Block>().type == BlockType.ASSIGNMENT)
            obj = obj.transform.GetChild(0).gameObject;

        foreach (Transform child in obj.transform)
        {
            if (child.GetComponentInChildren<VariableGap>() != null)
                gaps.Add(child.GetComponentInChildren<VariableGap>());
            else if (child.GetComponentInChildren<ValueGap>() != null)
                gaps.Add(child.GetComponentInChildren<ValueGap>());
        }

        return gaps;
    }

    public List<ConditionGap> getConditionGaps(GameObject obj)
    {
        List<ConditionGap> gaps = new List<ConditionGap>();

        foreach (Transform child in obj.transform)
        {
            if (child.GetComponentInChildren<ConditionGap>() != null)
                gaps.Add(child.GetComponentInChildren<ConditionGap>());
        }

        return gaps;
    }

    public void showErrorMessage(string message)
    {
        ToastMessage.showToastOnUiThread(message);
    }

    public void showErrorMarker(Image img)
    {
        Color c = img.color;
        img.color = Color.red;
        StartCoroutine(hideErrorMessage(img, c));
    }
    IEnumerator hideErrorMessage(Image img, Color c)
    {
        yield return new WaitForSeconds(5);
        img.color = c;
    }

    public string stringConcatenate(string str1, string str2)
    {
        str1 = str1.Remove(str1.Length - 1, 1);
        str2 = str2.Remove(0, 1);
        return str1 + str2;
    }

    public bool isRecursiveLevel()
    {
        return canDoRecursion;
    }

    public bool usedRecursion()
    {
        return recursionUsed;
    }

    public bool functionCallsCheck()
    {
        return !mustCallFunction || functionCalled;
    }

}
