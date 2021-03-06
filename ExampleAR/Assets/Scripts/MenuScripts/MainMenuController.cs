﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("LANGUAGE"))
        {
            PlayerPrefs.SetString("LANGUAGE", "ESP");
        }

        Localization.translate(FindObjectsOfType<Text>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void play()
    {
        if(PlayerPrefs.GetInt("FIRST", 1) == 1)
        {
            PlayerPrefs.SetInt("FIRST", 0);
            SceneManager.LoadScene(4);
        }
        else
        {
            SceneManager.LoadScene(1);
        }


    }

    public void training()
    {
        PlayerPrefs.SetString("TOPIC", "99");
        PlayerPrefs.SetString("LEVEL", "99");
        SceneManager.LoadScene(3);
    }

    public void settings()
    {
        SceneManager.LoadScene(5);
    }

}
