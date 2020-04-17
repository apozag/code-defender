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
        {"24", new List<string>(){"57.74334"} }
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentMessages = new List<string>();   
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
                    if (i >= currentMessages.Count || levelMessages[topicLevel][i] != currentMessages[i])
                    {
                        return false;
                    } 
                }
            }
            
        }
        return true;
    }
}
