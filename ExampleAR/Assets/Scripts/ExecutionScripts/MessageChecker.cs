using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageChecker : MonoBehaviour
{

    public List<string> currentMessages;

    static Dictionary<string, List<string>> levelMessages = new Dictionary<string, List<string>>()
    {
        {"14", new List<string>() },
        {"15", new List<string>(){"paso", "paso", "paso", "paso" } },
        {"24", new List<string>(){"\"57.74334\""} },
        {"29", new List<string>(){"\"JavaJavaJava\""} },
        {"210", new List<string>(){"\"El resultado es: 7\""} },
        {"35", new List<string>(){"say this", "and this"} },
        {"38", new List<string>(){"MSG_3_8_1"} },
        {"49", new List<string>(){"\"9\"", "\"1\"" , "\"4\"" , "\"3\"" } },
        {"55", new List<string>(){"\"Parameter: 3\"" } }

    };

    string language;

    // Start is called before the first frame update
    void Start()
    {
        currentMessages = new List<string>();
        language = PlayerPrefs.GetString("LANGUAGE");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool isGoalComplete()
    {
        string topicLevel = PlayerPrefs.GetString("TOPIC") + PlayerPrefs.GetString("LEVEL");
        if (levelMessages.ContainsKey(topicLevel))
        {
            if(currentMessages.Count > 0)
            {
                for (int i = 0; i < levelMessages[topicLevel].Count; i++)
                {
                    if (i >= currentMessages.Count || Localization.getString(levelMessages[topicLevel][i], language)!= currentMessages[i])
                    {
                        return false;
                    } 
                }
            }
            
        }
        return true;
    }

    public void reset()
    {
        currentMessages.Clear();
    }
}
