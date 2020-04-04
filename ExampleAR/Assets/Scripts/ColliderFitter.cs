using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderFitter : MonoBehaviour
{

    BoxCollider2D col;

    Image img;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        img = GetComponent<Image>();
        col.size = img.rectTransform.rect.size;
        col.offset = new Vector2(img.rectTransform.rect.size.x / 2, col.offset.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(col.size.x < 10)
        {
            col.size = img.rectTransform.rect.size;
        }
    }
}
