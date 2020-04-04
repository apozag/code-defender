using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompoundColliderFitter : MonoBehaviour
{
    Image[] images;

    BoxCollider2D col;

    RectTransform rt;

    // Start is called before the first frame update
    void Start()
    {
        images = GetComponentsInChildren<Image>();
        col = GetComponent<BoxCollider2D>();
        rt = GetComponent<RectTransform>();
        col.size = new Vector2(rt.sizeDelta.x, rt.sizeDelta.y);
        
        col.offset = new Vector2(col.size.x / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
