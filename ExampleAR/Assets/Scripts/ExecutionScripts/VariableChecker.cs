using System.Collections.Generic;
using UnityEngine;

public class VariableChecker : MonoBehaviour
{
    ValueType valueType;

    //TODO:: quitar esta mierda
    int intValue;
    string stringValue;
    float floatValue;

    CodePanelController cpc;

    static Dictionary<string, ValueType> levelTypes = new Dictionary<string, ValueType>()
    {
        {"21", ValueType.INT},
        {"22", ValueType.STRING},
        {"23", ValueType.FLOAT},
        {"24", ValueType.FLOAT},
        {"52", ValueType.STRING}
    };

    static Dictionary<string, int> levelIntValues = new Dictionary<string, int>();
    static Dictionary<string, float> levelFloatValues = new Dictionary<string, float>()
    {
        {"23", 12.0f },
        {"24", 57.74334f }
    };

    static Dictionary<string, string> levelStringValues = new Dictionary<string, string>()
    {
        {"22", "\"Hola\""},
        {"52", "\"Hola\""}
    };

    static Dictionary<string, List<int>> levelIntArrayValues = new Dictionary<string, List<int>>()
    {
    };

    static Dictionary<string, int> levelIntArraySizes = new Dictionary<string, int>()
    {
        {"45", 5 }
    };

    static Dictionary<string, string> levelIntNames = new Dictionary<string, string>();
    static Dictionary<string, string> levelStringNames = new Dictionary<string, string>()
    {
        {"22", "str2"},
        {"52", "local1"}
    };
    static Dictionary<string, string> levelFloatNames = new Dictionary<string, string>();
    static Dictionary<string, string> levelIntArrayNames = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        cpc = FindObjectOfType<CodePanelController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool isGoalComplete()
    {
        string topicLevel = PlayerPrefs.GetString("TOPIC", "") + PlayerPrefs.GetString("LEVEL", "");
        if (!topicLevel.Equals("") && !topicLevel.Equals("9999"))
        {
            if (levelTypes.ContainsKey(topicLevel))
            {
                switch (levelTypes[topicLevel])
                {
                    case ValueType.INT:
                        foreach (Variable<int> var in cpc.getIntVariables())
                        {
                            if (!levelIntValues.ContainsKey(topicLevel))
                                return true;
                            else if (var.value == levelIntValues[topicLevel])
                            {
                                if (!levelIntNames.ContainsKey(topicLevel))
                                    return true;
                                else
                                {
                                    if (levelIntNames[topicLevel] == var.name)
                                        return true;
                                }
                            }
                        }
                        return false;
                    case ValueType.STRING:
                        foreach (Variable<string> var in cpc.getStringVariables())
                        {
                            if (!levelStringValues.ContainsKey(topicLevel))
                                return true;
                            else if (var.value == levelStringValues[topicLevel])
                            {
                                if (!levelStringNames.ContainsKey(topicLevel))
                                    return true;
                                else
                                {
                                    if (levelStringNames[topicLevel] == var.name)
                                        return true;
                                }
                            }
                        }
                        return false;
                    case ValueType.FLOAT:
                        foreach (Variable<float> var in cpc.getFloatVariables())
                        {
                            if (!levelFloatValues.ContainsKey(topicLevel))
                                return true;
                            else if (var.value == levelFloatValues[topicLevel])
                            {
                                if (!levelFloatNames.ContainsKey(topicLevel))
                                    return true;
                                else
                                {
                                    if (levelFloatNames[topicLevel] == var.name)
                                        return true;
                                }
                            }
                        }
                        return false;
                    default:
                        ToastMessage.showToastOnUiThread("Ups! se ha producido un error.");
                        return false;
                }
            }

            //Tema arrays
            bool complete = false;
            if (levelIntArraySizes.ContainsKey(topicLevel))
            {
                foreach(Array<int> array in cpc.getIntArrays())
                {
                    if (array.size == levelIntArraySizes[topicLevel])
                    {
                        complete = true;
                        break;
                    }
                }
            }
            if (levelIntArrayNames.ContainsKey(topicLevel))
            {
                foreach (Array<int> array in cpc.getIntArrays())
                {
                    if (array.name == levelIntArrayNames[topicLevel])
                    {
                        complete = true;
                        break;
                    }
                    complete = false;
                }
            }
            if (levelIntArrayValues.ContainsKey(topicLevel)){
                foreach (Array<int> array in cpc.getIntArrays())
                {
                    bool temp = true;
                    for (int i = 0; i < array.values.Count; i++)
                    {
                        if(array.values[i] != levelIntArrayValues[topicLevel][i])
                        {
                            temp = false;
                            break;
                        }
                    }
                    if (temp)
                    {
                        complete = true;
                        break;
                    }
                    complete = false;
                }
            }
            return  complete;
        }
        else return true;
    }
}
