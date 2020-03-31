using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompoundColliderFitter : MonoBehaviour
{
    Image[] images;

    BoxCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        images = GetComponentsInChildren<Image>();
        col = GetComponent<BoxCollider2D>();
        col.size += new Vector2(0, images[0].rectTransform.rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        if(col.size.x < 10)
        {
            foreach(Image i in images)
            {
                col.size += new Vector2(i.rectTransform.rect.width, 0);
            }
        }
    }
}
