using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorController : MonoBehaviour
{

    public GameObject LoadingPanel;

    // Start is called before the first frame update
    void Start()
    {
        LoadingPanel.SetActive(false);
        Localization.translate(FindObjectsOfType<Text>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel(int level)
    {
        LoadingPanel.SetActive(true);
        PlayerPrefs.SetString("LEVEL", level.ToString());
        SceneManager.LoadScene(3);
    }

    public void back()
    {
        SceneManager.LoadScene(1);
    }
}
