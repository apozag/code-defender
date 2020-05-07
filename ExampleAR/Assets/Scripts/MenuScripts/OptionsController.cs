using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{

    [SerializeField] Text languageBtn;
    [SerializeField] GameObject popup;
    [SerializeField] Sprite SpanishIcon;
    [SerializeField] Sprite EnglishIcon;
    [SerializeField] Image languageIcon;

    // Start is called before the first frame update
    void Start()
    {
        Localization.translate(FindObjectsOfType<Text>());
        setLanguageIcon();
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
        Localization.translate(FindObjectsOfType<Text>());
        setLanguageIcon();
    }

    void setLanguageIcon()
    {
        if (PlayerPrefs.GetString("LANGUAGE") == "ESP")
        {
            languageIcon.sprite = EnglishIcon;
        }
        else
        {
            languageIcon.sprite = SpanishIcon;
        }
    }

    public void openPopup()
    {
        popup.SetActive(true);
        Localization.translate(popup.GetComponentsInChildren<Text>());
    }

    public void closePopup()
    {
        popup.SetActive(false);
    }

    public void restart()
    {
        popup.SetActive(false);
        PlayerPrefs.SetInt("NEXTTOPIC", 1);
        PlayerPrefs.SetInt("NEXTLEVEL", 1);
    }

    public void goBack()
    {
        SceneManager.LoadScene(0);
    }
}
