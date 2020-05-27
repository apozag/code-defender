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

    static Dictionary<string, List<int>> levelIntValues = new Dictionary<string, List<int>>()
    {
        { "310", new List<int>(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10} }
    };

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
        {"46", new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10} },
        {"47", new List<int>(){2, 4, 6, 8, 10, 12, 14, 16, 18, 20} },
        {"48", new List<int>(){ 5, 6, 4, 7, 3, 8, 2, 9, 1, 0 } },
        {"610", new List<int>(){  1, 2, 3, 3, 3, 4, 5, 6, 7, 9 } }
    };

    static Dictionary<string, int> levelIntArraySizes = new Dictionary<string, int>()
    {
        {"45", 5 },
        {"46", 10 }
    };

    static Dictionary<string, string> levelIntNames = new Dictionary<string, string>() {
        { "310", "number"}
    };
    static Dictionary<string, string> levelStringNames = new Dictionary<string, string>()
    {
        {"22", "word_2"},
        {"52", "local_1"}
    };
    static Dictionary<string, string> levelFloatNames = new Dictionary<string, string>();
    static Dictionary<string, string> levelIntArrayNames = new Dictionary<string, string>() {
        {"48", "copy" }
    };

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
                            else if (levelIntValues[topicLevel].Contains(var.value))
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
                            else if (var.value.Equals(levelStringValues[topicLevel]))
                            {
                                if (!levelStringNames.ContainsKey(topicLevel))
                                    return true;
                                else
                                {
                                    if (levelStringNames[topicLevel].Equals(var.name))
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
                            else if (var.value - levelFloatValues[topicLevel] < 0.1f && var.value - levelFloatValues[topicLevel] > -0.1f) 
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
            bool size, name, values;
            size = !levelIntArraySizes.ContainsKey(topicLevel);
            name = !levelIntArrayNames.ContainsKey(topicLevel);
            values = !levelIntArrayValues.ContainsKey(topicLevel);

            bool sizeUpdated, nameUpdated, valuesUpdated;
            sizeUpdated = size;
            nameUpdated = name;
            valuesUpdated = values;

            foreach (Array<int> array in cpc.getIntArrays())
            {
                if (!size && array.size == levelIntArraySizes[topicLevel])
                {
                    sizeUpdated = true;
                }
                if (!name && array.name == levelIntArrayNames[topicLevel])
                {
                    nameUpdated = true;
                }
                if (!values)
                {
                    bool aux = true;
                    for (int i = 0; i < levelIntArrayValues[topicLevel].Count; i++)
                    {
                        if (levelIntArrayValues[topicLevel][i] != array.values[i])
                        {
                            aux = false;
                            break;
                        }
                    }
                    if (aux)
                        valuesUpdated = true;
                }

                if(sizeUpdated && nameUpdated && valuesUpdated)
                {
                    size = sizeUpdated;
                    name = nameUpdated;
                    values = valuesUpdated;
                    break;
                }
            }

            return size && name && values;
        }
        else return true;
    }
}
