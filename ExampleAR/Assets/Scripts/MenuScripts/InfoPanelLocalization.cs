using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelLocalization : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string lang = PlayerPrefs.GetString("LANGUAGE");
        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");
        for(int i = 0; i < transform.childCount; i++)
        {
            Transform panel = transform.GetChild(i);
            panel.GetChild(0).GetComponent<Text>().text = Localization.getString("INF_" + topic + "_" + level + "_T_" + i, lang);
            panel.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = Localization.getString("CONTINUE", lang);
            panel.GetChild(2).GetComponent<Text>().text = Localization.getString("INF_" + topic + "_" + level + "_E_" + i, lang);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
