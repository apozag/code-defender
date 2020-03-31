using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public BlockType type;

    protected Vector2 startPositionTemp;
    protected Transform parentTemp;

    protected Vector2 startPosition;
    protected Transform parent;

    protected bool onDrag = false;

    int siblingIndex = 0;

    // Start is called before the first frame update
    public virtual void Start()
    {
        startPosition = transform.position;
        parent = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setParent(Transform p)
    {
        parentTemp = p;
    }

    public void setStartPos(Vector2 pos)
    {
        startPositionTemp = pos;
    }

    public bool isBeingDragged()
    {
        return onDrag;
    }

    public BlockType getBlockType()
    {
        return type;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        startPositionTemp = startPosition;
        siblingIndex = transform.GetSiblingIndex();
        parentTemp = parent.parent.parent.parent.parent;
        transform.SetParent(parentTemp);
        onDrag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        //startPosition = transform.position;
        startPositionTemp = startPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPositionTemp;
        transform.SetParent(parent);
        transform.SetSiblingIndex(siblingIndex);
        onDrag = false;
    }
}
