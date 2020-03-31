using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    bool on;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            on = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
            on = false;
    }

    public bool isPlayerOn()
    {
        return on;
    }

    public void reset()
    {
        transform.parent.position = GameObject.FindGameObjectWithTag("Floor").transform.position;
        on = false;
    }
}
