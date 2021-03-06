﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    VariableChecker variableChecker;
    MessageChecker messageChecker;

    

    BlocksGenerator bg;

    public RectTransform scrollPanel;
    public GameObject deleteBtn;
    public GameObject hideBtn;
    public GameObject popup;
    public GameObject winPopUp;
    public GameObject infoPanel;
    public GameObject tutorialPanel;
    public Interpreter interpreter;
    bool isScrollUp = true;
    string reusableString = "";

    int infoPanelIndex = -1;
    int tutorialPanelIndex = -1;

    string lang;

    // Use this for initialization
    void Start()
    {
        bg = FindObjectOfType<BlocksGenerator>();
        interpreter = FindObjectOfType<Interpreter>();
        variableChecker = GetComponent<VariableChecker>();
        messageChecker = GetComponent<MessageChecker>();
        lang = PlayerPrefs.GetString("LANGUAGE");

        popup.SetActive(true);
        winPopUp.SetActive(true);
        Localization.translate(popup.GetComponentsInChildren<Text>());
        Localization.translate(winPopUp.GetComponentsInChildren<Text>());
        popup.SetActive(false);
        winPopUp.SetActive(false);

        tutorialPanel.SetActive(false);
        showInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void scrollButton()
    {
        if (isScrollUp)
        {
            hideBtn.GetComponent<RectTransform>().localScale = new Vector3(1, -1, 1);
            scrollDown();
        }
        else
        {
            hideBtn.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            scrollUp();
        }
    }

    public void scrollUp()
    {
        StartCoroutine(MoveToPosition(scrollPanel.transform, new Vector3(scrollPanel.position.x, Screen.height * 0.8f), 0.3f));
        isScrollUp = true;
        deleteBtn.gameObject.SetActive(true);
    }
    public void scrollDown()
    {
        StartCoroutine(MoveToPosition(scrollPanel.transform, new Vector3(scrollPanel.position.x, Screen.height * 0.1f), 0.3f));
        isScrollUp = false;
        deleteBtn.gameObject.SetActive(false);
    }

    public IEnumerator MoveToPosition(Transform transform, Vector3 position, float timeToMove)
    {
        var currentPos = transform.position;
        var t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime / timeToMove;
            transform.position = Vector3.Lerp(currentPos, position, t);
            yield return null;
        }
    }

    public void showPopUp()
    {
        popup.SetActive(true);
        reusableString = "";
    }

    public void enterName()
    {
        reusableString = popup.GetComponentInChildren<InputField>().text;
        popup.SetActive(false);
        bg.setNewVarName(reusableString);
    }

    public void showInfo()
    {
        infoPanel.SetActive(true);
        if (infoPanelIndex >= 0)
            infoPanel.transform.GetChild(infoPanelIndex).gameObject.SetActive(false);

        if (infoPanelIndex + 1 < infoPanel.transform.childCount)
            infoPanel.transform.GetChild(++infoPanelIndex).gameObject.SetActive(true);
        else
        {
            infoPanel.SetActive(false);
            scrollDown();
            tutorialPanel.SetActive(true);
            infoPanelIndex = -1;
            showTutorial(-1);
        }

        //Localization.translate(infoPanel.GetComponentsInChildren<Text>());

    }
    public void showTutorial(int index)
    {
        if (index == tutorialPanelIndex)
        {
            if (tutorialPanelIndex >= 0)
                tutorialPanel.transform.GetChild(tutorialPanelIndex).gameObject.SetActive(false);

            if (tutorialPanelIndex + 1 < tutorialPanel.transform.childCount)
                tutorialPanel.transform.GetChild(++tutorialPanelIndex).gameObject.SetActive(true);
            else
            {
                tutorialPanel.SetActive(false);
            }
        }
    }

    public void execute()
    {
        
        interpreter.execute();
    }

    public void win()
    {
        if ((variableChecker != null && !variableChecker.isGoalComplete()) ||
            PlayerPrefs.GetString("TOPIC").Equals("99") ||
            (interpreter.isRecursiveLevel() && !interpreter.usedRecursion()) ||
            !interpreter.functionCallsCheck() ||
            (messageChecker != null && !messageChecker.isGoalComplete()))
        {
            loose();
        }
        else
        {
            winPopUp.SetActive(true);

            int topic = int.Parse(PlayerPrefs.GetString("TOPIC"));
            if (PlayerPrefs.GetInt("NEXTTOPIC", 1) <= topic)
            {
                int level = int.Parse(PlayerPrefs.GetString("LEVEL"));
                int nextLevel = PlayerPrefs.GetInt("NEXTLEVEL", 1);
                int max = Mathf.Max(level + 1, nextLevel);
                PlayerPrefs.SetInt("NEXTLEVEL", max);
                if (level >= NumLevels.numLevels[PlayerPrefs.GetString("TOPIC")])
                {
                    PlayerPrefs.SetInt("NEXTTOPIC", topic + 1);
                    PlayerPrefs.SetInt("NEXTLEVEL", 1);
                }
            }
        }
    }

    public void loose()
    {
        FindObjectOfType<PlayerMovement>().reset();
        if(messageChecker != null)
            messageChecker.reset();
        ToastMessage.showToastOnUiThread("Vuelve a intentarlo.");
    }
    public void goToLevelSelector()
    {
        SceneManager.LoadScene(2);
    }
    public void reloadLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void quit()
    {
        
        SceneManager.LoadScene(0);
    }

}
