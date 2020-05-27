using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableGap : MonoBehaviour
{

    public bool left;

    CodePanelController cpc;

    Draggable candidate;

    Image image;

    InputField ipf;

    //Condition currentCondition;

    protected static List<int> allowedTypes = new List<int>() {
        (int) BlockType.INT_VAR,
        (int) BlockType.STRING_VAR,
        (int) BlockType.FLOAT_VAR,
        (int) BlockType.INT_ARRAY_VAR
    };

    public bool empty = true;

    // Use this for initialization
    protected void Start()
    {
        cpc = FindObjectOfType<CodePanelController>();
        image = GetComponent<Image>();
        ipf = transform.GetComponentInChildren<InputField>();
    }

    // Update is called once per frame
    protected void Update()
    {
        if (empty && candidate != null)
        {
            if (!candidate.isBeingDragged() && allowedTypes.Contains((int)candidate.type))
            {
                bool success = false;
                switch (candidate.getBlockType())
                {
                    case BlockType.SUM:
                    case BlockType.SUBS:
                    case BlockType.MULT:
                    case BlockType.DIV:
                    case BlockType.RANDOM:
                        success = cpc.tryInsertOperation(candidate.getBlockType(), this);
                        break;
                    case BlockType.FUNCTION_RETURN_CALL:
                        success = cpc.tryInsertFunction(this);
                        break;
                    default:
                        success = cpc.tryInsertVariable(candidate.getBlockType(), candidate.GetComponentInChildren<Text>().text, this);
                        break;
                }
                Color c = image.color;
                c.a = 1.0f;
                image.color = c;
                if (success)
                {
                    image.enabled = false;
                    empty = false;
                    if (ipf != null)
                        ipf.gameObject.SetActive(false);
                }

                candidate = null;

            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        Draggable d = collision.GetComponent<Draggable>();
        if (d != null && d.isBeingDragged())
        {
            if (allowedTypes.Contains((int)d.type))
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

    public void resize(float width)
    {

    }

    public void reset()
    {
        BlocksGenerator.disableFitters(this.gameObject);
        Block content = GetComponentInChildren<Block>();

        if (content != null)
        {
            Destroy(content.gameObject);
        }

        //Canvas.ForceUpdateCanvases();

        empty = true;

        image.enabled = true;
        Color c = image.color;
        c.a = 1;
        image.color = c;


        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        BlocksGenerator.enableFitters(this.gameObject);
        
    }
}
