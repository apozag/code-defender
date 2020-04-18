using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Text languageBtn;

    // Start is called before the first frame update
    void Start()
    {
        Localization.translate(FindObjectsOfType<Text>());
        setLangBtnText();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeLanguage()
    {
        if(PlayerPrefs.GetString("LANGUAGE") == "ENG")
        {
            PlayerPrefs.SetString("LANGUAGE", "ESP");

        }
        else
        {
            PlayerPrefs.SetString("LANGUAGE", "ENG");
        }
        setLangBtnText();
        Localization.translate(FindObjectsOfType<Text>());
    }

    void setLangBtnText()
    {
        if (PlayerPrefs.GetString("LANGUAGE") == "ENG")
        {
            languageBtn.text = "Cambiar a Español";
        }
        else
        {
            languageBtn.text = "Switch to English";
        }
    }

    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
}
