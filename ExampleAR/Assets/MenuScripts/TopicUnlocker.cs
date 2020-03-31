using UnityEngine;
using UnityEngine.UI;

public class TopicUnlocker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int nextTopic = PlayerPrefs.GetInt("NEXTTOPIC", 1);

        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    if (i + 1 > nextTopic)
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
