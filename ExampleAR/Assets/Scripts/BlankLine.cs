using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlankLine : MonoBehaviour {

    public CodePanelController cpc;

    Image image;

    Draggable candidate;

    static List<int> allowedTypes = new List<int>(){
        (int)BlockType.CLASS,
        (int) BlockType.FUNCTION,
        (int) BlockType.FUNCTION_CALL,
        (int) BlockType.MAIN_FUNCTION,
        (int) BlockType.STEP,
        (int) BlockType.TURN_LEFT,
        (int) BlockType.TURN_RIGHT,
        (int) BlockType.WHILE,
        (int) BlockType.FOR,
        (int) BlockType.IF,
        (int) BlockType.ELSE_IF,
        (int) BlockType.ELSE,
        (int) BlockType.ASSIGNMENT,
        (int) BlockType.DECLARE_INT,
        (int) BlockType.DECLARE_STRING,
        (int) BlockType.DECLARE_FLOAT
    };

    // Use this for initialization
    void Start () {
        image = GetComponentInChildren<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(candidate != null)
        {
            if (!candidate.isBeingDragged() && allowedTypes.Contains((int)candidate.type))
            {
                if(cpc.tryInsert(candidate.getBlockType(), transform.GetSiblingIndex()))
                    Destroy(gameObject);
                else
                    candidate = null;
            }
        }
	}

    public void OnTriggerEnter2D(Collider2D collision)

    {
        Draggable d = collision.gameObject.GetComponent<Draggable>();
        if(d != null)
        {
            if (d.isBeingDragged())
            {
                Color c = image.color;
                c.a = 0.5f;
                image.color = c;

                candidate = d;
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Draggable d = collision.gameObject.GetComponent<Draggable>();
        if (d != null)
        {
            if (d.isBeingDragged())
            {
                Color c = image.color;
                c.a = 1.0f;
                image.color = c;

                candidate = null;
            }
        }
    }
}
