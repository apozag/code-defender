using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFitter : MonoBehaviour
{
    Text textObject;
    InputField ip;
    ContentSizeFitter csf;
    RectTransform rt;
    string text = "";

    // Start is called before the first frame update
    void Start()
    {
        ip = GetComponent<InputField>();
        csf = GetComponent<ContentSizeFitter>();
        rt = GetComponent<RectTransform>();
        textObject = ip.textComponent;
    }

    // Update is called once per frame
    void Update()
    {
        this.text = ip.text;
        if (csf.enabled && text.Equals(""))
        {
            csf.enabled = false;
            rt.sizeDelta = new Vector2(50, rt.rect.height);
        }

        if (textObject.text.Length < text.Length)
        {
            csf.enabled = true;
            textObject.rectTransform.sizeDelta = new Vector2(textObject.rectTransform.rect.width + 5, textObject.rectTransform.rect.height);
        }
        else if (textObject.text.Length < text.Length)
            textObject.rectTransform.sizeDelta = new Vector2(textObject.rectTransform.rect.width - 5, textObject.rectTransform.rect.height);
    }

    public void updateText()
    {
        this.text = ip.text;
    }
}
