using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
    CLASS,
    FUNCTION,
    MAIN_FUNCTION,

    WHILE,
    FOR,

    IF,
    ELSE_IF,
    ELSE,

    ASSIGNMENT,

    DECLARE_INT,
    DECLARE_STRING,
    DECLARE_FLOAT,

    INT_VAR,
    STRING_VAR,
    FLOAT_VAR,

    STEP,
    TURN_LEFT,
    TURN_RIGHT,

    TRUE,
    FALSE,
    EQUALS,
    NOT_EQUAL,
    GREATER_THAN,
    LESS_THAN,
    LESS_EQUAL_THAN,
    GREATER_EQUAL_THAN,
    AND,
    OR,

    SUM,
    SUBS,
    MULT,
    DIV, 

    FUNCTION_CALL,

    DO_WHILE,
    DECLARE_INT_ARRAY,
    INT_ARRAY_VAR, 

    SAY,
    STEP_NUM,

    RANDOM,

    DECLARE_STATIC_INT,
    DECLARE_STATIC_STRING,
    DECLARE_STATIC_FLOAT,
    DECLARE_STATIC_INT_ARRAY,

    FUNCTION_ARG,
    FUNCTION_ARG_CALL,

    FUNCTION_RETURN,
    FUNCTION_RETURN_CALL,
    RETURN

}

public class Block : MonoBehaviour {

    public int id;

    public int scope;

    public BlockType type;

    public bool head;

    public bool hasEndBlock;

    public bool inner;

    float offset = 0;


	// Use this for initialization
	void Start () {
        id = Random.Range(0, 9999);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool isHead()
    {
        return head;
    }

    public void setOffset(float offset)
    {
        this.offset = offset;
    }

    public float getOffset()
    {
        return offset;
    }

}
