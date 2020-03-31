using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ClickableBlock : EventTrigger {

    public CodePanelController cpc;

	// Use this for initialization
	void Start () {
        cpc = FindObjectOfType<CodePanelController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnPointerDown(PointerEventData data)
    {
        foreach (Image img in GetComponentsInChildren<Image>())
        {
            Color c = img.color;
            c.a = 0.5f;
            img.color = c;
        }

        cpc.selectBlock(GetComponent<Block>());
    }
    public void unselect()
    {

        foreach (Image img in GetComponentsInChildren<Image>())
        {
            Color c = img.color;
            c.a = 1.0f;
            img.color = c;
        }

    }
}
