using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonologueDisplayer : MonoBehaviour
{

    Text text;

    string currentParagraph;

    int index;

    bool charLock = true;


    List<string> paragraphs; 

    // Start is called before the first frame update
    void Start()
    {
        string lang = PlayerPrefs.GetString("LANGUAGE");

        paragraphs = new List<string>(); ;
        paragraphs.Add(Localization.getString("MON_1", lang));
        paragraphs.Add(Localization.getString("MON_2", lang));
        paragraphs.Add(Localization.getString("MON_3", lang));
        paragraphs.Add(Localization.getString("MON_4", lang));
        paragraphs.Add(Localization.getString("MON_5", lang));
        paragraphs.Add(Localization.getString("MON_6", lang));
        paragraphs.Add(Localization.getString("MON_7", lang));
        paragraphs.Add(Localization.getString("MON_8", lang));
        paragraphs.Add(Localization.getString("MON_9", lang));
        paragraphs.Add(Localization.getString("MON_10", lang));


        text = GetComponentInChildren<Text>();

        index = 0;

        showNextPragraph();
    }

    // Update is called once per frame
    void Update()
    {
        if (charLock)
        {
            StartCoroutine(showNextChar());
            charLock = false;
        }
        
    }

    public void showNextPragraph()
    {
        if (paragraphs.Count > 0)
        {
            currentParagraph = paragraphs[0];
            paragraphs.RemoveAt(0);
            index = 0;
            text.text = "";
        }
        else
        {
            goToTopicSelect();
        }
    }

    IEnumerator showNextChar()
    {
        yield return new WaitForSeconds(0.005f);
        for (int i = 0; i < 2; i++)
        {
            if (index < currentParagraph.Length)
            {
                text.text += currentParagraph[index];
                index++;
            }
        }

        charLock = true;

    }

    void goToTopicSelect()
    {
        SceneManager.LoadScene(1);
    }

}
