using System.Collections.Generic;

public static class VariablesLoadHelper
{

    static Dictionary<string, List<Variable<int>>> intVariables = new Dictionary<string, List<Variable<int>>>()
    {
        {"31", new List<Variable<int>>()
        {
            new Variable<int>("foo", 1, 1, 2)
        } },
        {"32", new List<Variable<int>>()
        {
            new Variable<int>("foo", 2, 1, 2)
        } },
        {"41", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 1, 2)
        } },
        {"42", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 2, 2)
        } },
        {"43", new List<Variable<int>>(){
            new Variable<int>("i", 1, 2, 2),
            new Variable<int>("j", 0, 3, 4)
        } },
        {"53", new List<Variable<int>>(){
            new Variable<int>("contador", 0, 0, 2)
        } },
        {"61", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 0, 1)
        } }
    };
    static Dictionary<string, List<Variable<string>>> stringVariables = new Dictionary<string, List<Variable<string>>>()
    {
        {"22", new List<Variable<string>>()
        {
            new Variable<string>("str", "\"Hola\"", 1, 3),
            new Variable<string>("str2", "\"Mundo\"", 1, 5)
        }},

        {"33", new List<Variable<string>>()
        {
            new Variable<string>("str1", "\"Code\"", 1, 2),
            new Variable<string>("str2", "\" Defender\"", 1, 3)
        }},
        {"52", new List<Variable<string>>()
        {
            new Variable<string>("local1", "\"Hola\"", 1, 4),
            new Variable<string>("local2", "\"Mundo\"", 1, 10)
        }}
    };
    static Dictionary<string, List<Variable<float>>> floatVariables = new Dictionary<string, List<Variable<float>>>()
    {
        {"23", new List<Variable<float>>()
        {
            new Variable<float>("num1", 5.0f, 1, 3),
            new Variable<float>("num2", 7.0f, 1, 5)
        } },
        {"32", new List<Variable<float>>()
        {
            new Variable<float>("var", 1.5f, 1, 3)
        } }
    };


    public static List<Variable<string>> getStringVariables(string topicLevel)
    {
        if (stringVariables.ContainsKey(topicLevel))
            return stringVariables[topicLevel];
        else
            return new List<Variable<string>>();
    }

    public static List<Variable<int>> getIntVariables(string topicLevel)
    {
        if (intVariables.ContainsKey(topicLevel))
            return intVariables[topicLevel];
        else
            return new List<Variable<int>>();
    }

    public static List<Variable<float>> getFloatVariables(string topicLevel)
    {
        if (floatVariables.ContainsKey(topicLevel))
            return floatVariables[topicLevel];
        else
            return new List<Variable<float>>();
    }
}
