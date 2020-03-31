using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConditionGap : MonoBehaviour
{

    CodePanelController cpc;

    Draggable candidate;

    Image image;

    static List<int> allowedTypes = new List<int>()
    {
        (int)BlockType.TRUE,
        (int) BlockType.FALSE,
        (int) BlockType.EQUALS,
        (int) BlockType.NOT_EQUAL,
        (int) BlockType.GREATER_THAN,
        (int) BlockType.LESS_THAN,
        (int) BlockType.GREATER_EQUAL_THAN,
        (int) BlockType.LESS_EQUAL_THAN,
        (int) BlockType.AND,
        (int) BlockType.OR
    };

    public bool empty = true;

    // Use this for initialization
    void Start()
    {
        cpc = FindObjectOfType<CodePanelController>();
        image = GetComponent<Image>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (empty && candidate != null)
        {
            if (!candidate.isBeingDragged())
            {
                if (cpc.tryInsertCondition(candidate.getBlockType(), this))
                {
                    image.enabled = false;
                    empty = false;
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
        //image.rectTransform.sizeDelta = new Vector2(width, image.rectTransform.rect.height);// rect.Set(0, 0, width, image.rectTransform.rect.height);
        //transform.parent.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(width, transform.parent.GetComponent<Image>().rectTransform.rect.height);
    }

    public void reset()
    {
        BlocksGenerator.disableFitters(this.gameObject);
        Destroy(GetComponentInChildren<Block>().gameObject);

        Canvas.ForceUpdateCanvases();

        image.enabled = true;
        Color c = image.color;
        c.a = 1.0f;
        image.color = c;

        BlocksGenerator.enableFitters(this.gameObject);
        empty = true;
    }
}
