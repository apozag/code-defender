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
    }

    // Update is called once per frame
    void Update()
    {
        col.size = img.rectTransform.rect.size;

    }
}
