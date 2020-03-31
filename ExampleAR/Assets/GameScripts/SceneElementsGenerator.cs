using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneElementsGenerator : MonoBehaviour
{
    GameObject elements;

    public GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");
         
        if (!topic.Equals("99") && !level.Equals("99"))
        {
            elements = Resources.Load<GameObject>("Elements_" + topic + "_" + level);
            if (elements != null)
            {
                GameObject obj = Instantiate(elements, floor.transform.position, floor.transform.rotation);
                obj.transform.forward = floor.transform.forward;
                obj.transform.SetParent(transform.parent);
                GetComponent<GoalChecker>().findElements();
                foreach(Enemy e in elements.GetComponentsInChildren<Enemy>())
                {
                    e.transform.position += new Vector3(0, 0, -0.1f);
                    e.transform.Rotate(new Vector3(0, Random.Range(0, 360), 0));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
