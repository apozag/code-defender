using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    [SerializeField] int topic;

   
    // Start is called before the first frame update
    void Start()
    {
        Image fillBar = transform.GetChild(1).GetComponent<Image>();
        int nextTopic = PlayerPrefs.GetInt("NEXTTOPIC");
        if ( nextTopic > topic)
        {
            fillBar.fillAmount = 1;
        }
        else if (nextTopic < topic)
        {
            fillBar.transform.parent.gameObject.SetActive(false);
        }
        else
        {
            fillBar.fillAmount = ((float)PlayerPrefs.GetInt("NEXTLEVEL") - 1) / NumLevels.numLevels[topic.ToString()] ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
