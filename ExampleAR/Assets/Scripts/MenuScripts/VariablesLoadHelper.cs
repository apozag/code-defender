using System.Collections.Generic;

public static class VariablesLoadHelper
{

    static Dictionary<string, List<Variable<int>>> intVariables = new Dictionary<string, List<Variable<int>>>()
    {
        {"25", new List<Variable<int>>(){
            new Variable<int>("cm", 456, 1, null),
            new Variable<int>("cm_per_step", 76, 1, null)
        } },
         {"26", new List<Variable<int>>(){
            new Variable<int>("total_steps", 21, 1, null)
        } },
        {"27", new List<Variable<int>>(){
            new Variable<int>("value_1", 3, 1, null),
            new Variable<int>("value_2", 9, 1, null)
        } },
        {"28", new List<Variable<int>>(){
            new Variable<int>("value", 4, 1, null),
        } },
        {"210", new List<Variable<int>>(){
            new Variable<int>("total_steps", 7, 1, null),
        } },
        {"31", new List<Variable<int>>()
        {
            new Variable<int>("awesome_number", 1, 1, null)
        } },
        {"32", new List<Variable<int>>()
        {
            new Variable<int>("level", 2, 1, null)
        } },
        {"34", new List<Variable<int>>()
        {
            new Variable<int>("cool_number", 23, 1, null)
        } },
        {"36", new List<Variable<int>>()
        {
            new Variable<int>("result", 15, 1, null),
            new Variable<int>("operand", 3, 1, null)
        } },
        {"37", new List<Variable<int>>()
        {
            new Variable<int>("random_num", 5, 1, null)
        } },
        {"38", new List<Variable<int>>()
        {
            new Variable<int>("average", 0, 1, null),
            new Variable<int>("number", 0, 1, null)
        } },
        {"39", new List<Variable<int>>()
        {
            new Variable<int>("random_num", 5, 1, null)
        } },
        {"310", new List<Variable<int>>()
        {
            new Variable<int>("random_num", 5, 1, null)
        } },
        {"41", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 1, null)
        } },
        {"42", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 2, null)
        } },
        {"43", new List<Variable<int>>(){
            new Variable<int>("i", 1, 2, null),
            new Variable<int>("j", 0, 3, null)
        } },
        {"48", new List<Variable<int>>(){
            new Variable<int>("i", 0, 2, null)
        } },
        {"49", new List<Variable<int>>(){
            new Variable<int>("i", 0, 2, null)
        } },
        {"410", new List<Variable<int>>(){
            new Variable<int>("i", 0, 2, null)
        } },
        {"53", new List<Variable<int>>(){
            new Variable<int>("contador", 0, 0, null)
        } },
        {"54", new List<Variable<int>>(){
            new Variable<int>("contador", 0, 0, null)
        } },
        {"55", new List<Variable<int>>(){
            new Variable<int>("param", 0, 0, null)
        } },
        {"510", new List<Variable<int>>(){
            new Variable<int>("param", 0, 1, null),
            new Variable<int>("count", 0, 0, null)
        } },
        {"61", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 0, null)
        } },
        {"64", new List<Variable<int>>()
        {
            new Variable<int>("param", 0, 1, null)
        } },
        {"68", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 0, null)
        } },
        {"69", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 0, null)
        } },
        {"610", new List<Variable<int>>()
        {
            new Variable<int>("i", 0, 0, null)
        } },
    };
    static Dictionary<string, List<Variable<string>>> stringVariables = new Dictionary<string, List<Variable<string>>>()
    {
        {"22", new List<Variable<string>>()
        {
            new Variable<string>("word_1", "\"Hola\"", 1, null),
            new Variable<string>("word_2", "\"Mundo\"", 1, null)
        }},

         {"29", new List<Variable<string>>()
        {
            new Variable<string>("word", "\"Java\"", 1, null),
        }},
        {"210", new List<Variable<string>>()
        {
            new Variable<string>("word", "\"El resultado es: \"", 1, null),
        }},

        {"33", new List<Variable<string>>()
        {
            new Variable<string>("word_1", "\"Code\"", 1, null),
            new Variable<string>("word_2", "\"Code Defender\"", 1, null)
        }},
         {"34", new List<Variable<string>>()
        {
            new Variable<string>("word_1", "\"Code\"", 1, null),
            new Variable<string>("word_2", "\"Code Defender\"", 1, null)
        }},
        {"52", new List<Variable<string>>()
        {
            new Variable<string>("local_1", "\"Hola\"", 1, null),
            new Variable<string>("local_2", "\"Mundo\"", 1, null)
        }}
    };
    static Dictionary<string, List<Variable<float>>> floatVariables = new Dictionary<string, List<Variable<float>>>()
    {
        {"23", new List<Variable<float>>()
        {
            new Variable<float>("operand_1", 5.0f, 1, null),
            new Variable<float>("operand_2", 7.0f, 1, null)
        } },
        {"24", new List<Variable<float>>(){
            new Variable<float>("primer_tiempo", 60.43f, 1, null),
            new Variable<float>("segundo_tiempo", 68.79f, 1, null),
            new Variable<float>("tercer_tiempo", 44.01f, 1, null),
        } },
        {"32", new List<Variable<float>>()
        {
            new Variable<float>("experience", 1.5f, 1, null)
        } }
    };
    static Dictionary<string, List<Array<int>>> intArrays = new Dictionary<string, List<Array<int>>>()
    {
        {"48", new List<Array<int>>()
        {
            new Array<int>("original", 10, 1, null),
            new Array<int>("copy", 10, 1, null)
        } },
        {"49", new List<Array<int>>()
        {
            new Array<int>("numbers", 4, 1, null),
        } },
        {"410", new List<Array<int>>()
        {
            new Array<int>("numbers", 5, 1, null),
        } },
        {"68", new List<Array<int>>()
        {
            new Array<int>("values", 6, 0, null),
        } },
        {"69", new List<Array<int>>()
        {
            new Array<int>("values", 10, 0, null),
        } },
        {"610", new List<Array<int>>()
        {
            new Array<int>("values", 10, 0, null),
        } },
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
    public static List<Array<int>> getIntArrays(string topicLevel)
    {
        if (intArrays.ContainsKey(topicLevel))
        {
            return intArrays[topicLevel];
        }
        else
            return new List<Array<int>>();
    }
}
