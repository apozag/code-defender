using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localization : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Text text in FindObjectsOfType<Text>())
        {
            text.text = Strings.getString(text.text, PlayerPrefs.GetString("LANGUAGE"));
        }
    }

    public static void change()
    {
        foreach (Text text in FindObjectsOfType<Text>())
        {
            //text.text = Strings.getString(text.text, PlayerPrefs.GetString("LANGUAGE"));
            switch (text.text)
            {
                case "Básicos":
                    text.text = "3_CAT_BASIC";
                    break;
                case "Bucles":
                    text.text = "3_CAT_LOOPS";
                    break;
                case "Variables":
                    text.text = "3_CAT_VARIABLES";
                    break;
                case "Movimiento":
                    text.text = "3_CAT_MOVEMENT";
                    break;
                case "Comparación":
                    text.text = "3_CAT_COMPARISON";
                    break;
                case "Operaciones":
                    text.text = "3_CAT_OPERATIONS";
                    break;
                case "Ramificación":
                    text.text = "3_CAT_BRANCH";
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
