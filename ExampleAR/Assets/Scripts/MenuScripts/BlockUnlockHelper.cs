using System.Collections.Generic;
using System;
using UnityEngine;

public static class BlockUnlockHelper
{

    static Dictionary<int, BlockType[]> lockedBlocks = new Dictionary<int, BlockType[]>()
    {
        {35, new BlockType[]
        {
            BlockType.SAY 
        } },
        {64, new BlockType[]
        {
            BlockType.FUNCTION,
            BlockType.FUNCTION_CALL
        } },
        { 65, new BlockType[]
        {
            BlockType.FUNCTION,
            BlockType.FUNCTION_CALL,
            BlockType.FUNCTION_ARG,
            BlockType.FUNCTION_ARG_CALL,
        } }
    };

    static Dictionary<int, BlockType[]> unlockedBlocks = new Dictionary<int, BlockType[]>()
        {
            {11, new BlockType[]{
                BlockType.CLASS,
                BlockType.MAIN_FUNCTION,
                BlockType.STEP,
            } },

            {12, new BlockType[]{
                BlockType.TURN_LEFT,
                BlockType.TURN_RIGHT
            } },

            {14, new BlockType[]{
                BlockType.SAY
            } },

            {21, new BlockType[]{
                BlockType.DECLARE_INT,
                BlockType.ASSIGNMENT
            } },

            {22, new BlockType[]{
                BlockType.DECLARE_STRING,
                BlockType.DECLARE_FLOAT
            } },

            {23, new BlockType[]{
                BlockType.SUM,
                BlockType.SUBS,
                BlockType.MULT,
                BlockType.DIV
            } },

            {31, new BlockType[]{
                BlockType.IF,
                BlockType.EQUALS,
                BlockType.GREATER_THAN,
                BlockType.GREATER_EQUAL_THAN,
                BlockType.LESS_THAN,
                BlockType.LESS_EQUAL_THAN,
                BlockType.NOT_EQUAL
            } },

            {32, new BlockType[]{
                BlockType.ELSE_IF,
                BlockType.ELSE
            } },

            {33, new BlockType[]{
                BlockType.AND,
                BlockType.OR
            } },

             {37, new BlockType[]{
                BlockType.RANDOM,
            } },

            {41, new BlockType[]{
                BlockType.WHILE
            } },

            {42, new BlockType[]{
                BlockType.FOR
            } },

            {44, new BlockType[]{
                BlockType.DO_WHILE,
                BlockType.DECLARE_INT_ARRAY
            } },

            {51, new BlockType[]{
                BlockType.FUNCTION_CALL
            } },

            {55, new BlockType[]{
                BlockType.FUNCTION_ARG_CALL,
                BlockType.FUNCTION_ARG
            } },
            {65, new BlockType[]{
                BlockType.FUNCTION_RETURN,
                BlockType.FUNCTION_RETURN_CALL,
                BlockType.RETURN
            } },

            {99, new BlockType[]
            {
                BlockType.FUNCTION
            } }
        };

    static Dictionary<BlockType, int> categories = new Dictionary<BlockType, int>()
    {
        {BlockType.CLASS, 0},
        {BlockType.MAIN_FUNCTION, 0},
        {BlockType.STEP, 3},
        {BlockType.TURN_LEFT, 3},
        {BlockType.TURN_RIGHT, 3},
        {BlockType.SAY, 3},
        {BlockType.DECLARE_INT, 2},
        {BlockType.ASSIGNMENT, 2},
        {BlockType.DECLARE_STRING, 2},
        {BlockType.DECLARE_FLOAT, 2},
        {BlockType.DECLARE_INT_ARRAY, 2},
        {BlockType.SUM, 5},
        {BlockType.SUBS, 5},
        {BlockType.MULT, 5},
        {BlockType.DIV, 5},
        {BlockType.RANDOM, 5},
        {BlockType.IF, 6},
        {BlockType.ELSE_IF, 6},
        {BlockType.ELSE, 6},
        {BlockType.EQUALS, 4},
        {BlockType.NOT_EQUAL, 4},
        {BlockType.GREATER_THAN, 4},
        {BlockType.GREATER_EQUAL_THAN, 4},
        {BlockType.LESS_EQUAL_THAN, 4},
        {BlockType.LESS_THAN, 4},
        {BlockType.AND, 4},
        {BlockType.OR, 4},
        {BlockType.TRUE, 4},
        {BlockType.FALSE, 4},
        {BlockType.WHILE, 1},
        {BlockType.FOR, 1},
        {BlockType.DO_WHILE, 1},
        {BlockType.FUNCTION_CALL, 0},
        {BlockType.FUNCTION_ARG_CALL, 0},
        {BlockType.FUNCTION_RETURN_CALL, 0},
        {BlockType.FUNCTION, 0},
        {BlockType.FUNCTION_ARG, 0},
        {BlockType.FUNCTION_RETURN, 0},
        {BlockType.RETURN, 0}

    };
    static Dictionary<BlockType, GameObject> draggablePrefabs = new Dictionary<BlockType, GameObject>()
    {
        {BlockType.CLASS,               Resources.Load<GameObject>("Prefabs/Draggables/Basic/class_d")},
        {BlockType.MAIN_FUNCTION,       Resources.Load<GameObject>("Prefabs/Draggables/Basic/mainmethod_d")},
        {BlockType.FUNCTION_CALL,       Resources.Load<GameObject>("Prefabs/Draggables/Basic/functioncall_d")},
        {BlockType.FUNCTION_ARG_CALL,   Resources.Load<GameObject>("Prefabs/Draggables/Basic/functionargcall_d")},
        {BlockType.FUNCTION_RETURN_CALL,Resources.Load<GameObject>("Prefabs/Draggables/Basic/functionreturncall_d")},
        {BlockType.STEP,                Resources.Load<GameObject>("Prefabs/Draggables/Movement/step_d")},
        {BlockType.TURN_LEFT,           Resources.Load<GameObject>("Prefabs/Draggables/Movement/turnleft_d")},
        {BlockType.TURN_RIGHT,          Resources.Load<GameObject>("Prefabs/Draggables/Movement/turnright_d")},
        {BlockType.SAY,                 Resources.Load<GameObject>("Prefabs/Draggables/Movement/say_d")},
        {BlockType.ASSIGNMENT,          Resources.Load<GameObject>("Prefabs/Draggables/Variables/assignment_d")},
        {BlockType.DECLARE_INT,         Resources.Load<GameObject>("Prefabs/Draggables/Variables/declareint_d")},
        {BlockType.DECLARE_STRING,      Resources.Load<GameObject>("Prefabs/Draggables/Variables/declarestring_d")},
        {BlockType.DECLARE_FLOAT,       Resources.Load<GameObject>("Prefabs/Draggables/Variables/declarefloat_d")},
        {BlockType.DECLARE_INT_ARRAY,   Resources.Load<GameObject>("Prefabs/Draggables/Variables/declareintarray_d")},
        {BlockType.SUM,                 Resources.Load<GameObject>("Prefabs/Draggables/Operations/sum_d")},
        {BlockType.SUBS,                Resources.Load<GameObject>("Prefabs/Draggables/Operations/sub_d")},
        {BlockType.MULT,                Resources.Load<GameObject>("Prefabs/Draggables/Operations/mult_d")},
        {BlockType.DIV,                 Resources.Load<GameObject>("Prefabs/Draggables/Operations/div_d")},
        {BlockType.RANDOM,              Resources.Load<GameObject>("Prefabs/Draggables/Operations/rand_d")},
        {BlockType.IF,                  Resources.Load<GameObject>("Prefabs/Draggables/Branch/if_d")},
        {BlockType.ELSE_IF,             Resources.Load<GameObject>("Prefabs/Draggables/Branch/elseif_d")},
        {BlockType.ELSE,                Resources.Load<GameObject>("Prefabs/Draggables/Branch/else_d")},
        {BlockType.EQUALS,              Resources.Load<GameObject>("Prefabs/Draggables/Condition/equals_d")},
        {BlockType.NOT_EQUAL,           Resources.Load<GameObject>("Prefabs/Draggables/Condition/notequal_d")},
        {BlockType.GREATER_THAN,        Resources.Load<GameObject>("Prefabs/Draggables/Condition/greaterthan_d")},
        {BlockType.GREATER_EQUAL_THAN,  Resources.Load<GameObject>("Prefabs/Draggables/Condition/greaterequal_d")},
        {BlockType.LESS_EQUAL_THAN,     Resources.Load<GameObject>("Prefabs/Draggables/Condition/lessequal_d")},
        {BlockType.LESS_THAN,           Resources.Load<GameObject>("Prefabs/Draggables/Condition/lessthan_d")},
        {BlockType.AND,                 Resources.Load<GameObject>("Prefabs/Draggables/Condition/and_d")},
        {BlockType.OR,                  Resources.Load<GameObject>("Prefabs/Draggables/Condition/or_d")},
        {BlockType.WHILE,               Resources.Load<GameObject>("Prefabs/Draggables/Loops/while_d")},
        {BlockType.FOR,                 Resources.Load<GameObject>("Prefabs/Draggables/Loops/for_d")},
        {BlockType.DO_WHILE,            Resources.Load<GameObject>("Prefabs/Draggables/Loops/dowhile_d")},
        {BlockType.FUNCTION,            Resources.Load<GameObject>("Prefabs/Draggables/Basic/auxmethod_d")},
        {BlockType.FUNCTION_ARG,        Resources.Load<GameObject>("Prefabs/Draggables/Basic/auxmethodarg_d")},
        {BlockType.FUNCTION_RETURN,     Resources.Load<GameObject>("Prefabs/Draggables/Basic/auxmethodreturn_d")},
        {BlockType.RETURN,              Resources.Load<GameObject>("Prefabs/Draggables/Basic/return_d")}
    };

    public static List<BlockType> getUnlockedBlocks(string topic, string level)
    {
        List<BlockType> types = new List<BlockType>();

        int key = 0;

        if (topic.Equals("99") || level.Equals("99"))
        {
            key = int.Parse("" + PlayerPrefs.GetInt("NEXTTOPIC", 0) + PlayerPrefs.GetInt("NEXTLEVEL", 0));
        }
        else
        {
            key = int.Parse(topic + level);
        }

        foreach (KeyValuePair<int, BlockType[]> entry in unlockedBlocks)
        {
            if (entry.Key <= key)
            {
                foreach (BlockType t in entry.Value)
                {
                    if (!(lockedBlocks.ContainsKey(key) && Array.Exists(lockedBlocks[key], element => element == t)))
                    {
                        types.Add(t);
                    }
                }
            }
            else
                break;
        }
        return types;
    }

    public static int getCategory(BlockType type)
    {
        return categories[type];
    }

    public static GameObject getDraggablePrefab(BlockType type)
    {
        GameObject obj = draggablePrefabs[type];
        return obj;
    }

}
