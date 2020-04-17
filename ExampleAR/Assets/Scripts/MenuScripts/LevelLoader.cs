using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelLoader : MonoBehaviour
{
    //public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        loadLevel();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static void loadLevel()
    {
        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");

        Canvas prefab;

       if (!topic.Equals("99") && !level.Equals("99"))
            prefab = Resources.Load<Canvas>("Levels/level_" + topic + "_" + level);
        else
            prefab = Resources.Load<Canvas>("training");

        if (prefab != null)
        {
            Canvas levelInstance = Instantiate(prefab);
            levelInstance.transform.SetSiblingIndex(1);
        }

        Localization.change();
    }

    public void info()
    {
        FindObjectOfType<UIController>().showInfo();
    }

    public void quit()
    {
        if (PlayerPrefs.GetString("TOPIC", "99").Equals("99"))
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }


}
