using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        int nextTopic = PlayerPrefs.GetInt("NEXTTOPIC", 1);

        int nextLevel = PlayerPrefs.GetInt("NEXTLEVEL", 1);

        string topicString = PlayerPrefs.GetString("TOPIC");
        int topicInt = int.Parse(topicString);

        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    if (i >= UIController.numLevels[topicString])
        //        transform.GetChild(i).gameObject.SetActive(false);
        //    else if (topicInt == nextTopic && i + 1 > nextLevel)
        //    {
        //        Color c = transform.GetChild(i).GetComponent<Image>().color;
        //        c.a = 0.5f;
        //        transform.GetChild(i).GetComponent<Image>().color = c;

        //        transform.GetChild(i).GetComponent<Button>().interactable = false;
        //    }
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
