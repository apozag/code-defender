using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopicSelectorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectTopic(int topic)
    {
        PlayerPrefs.SetString("TOPIC", topic.ToString());
        SceneManager.LoadScene(2);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
