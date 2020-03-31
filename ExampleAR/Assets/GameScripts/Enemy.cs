using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    bool dead = false;

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
        {
            dead = true;
            GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public bool isDead()
    {
        return dead;
    }

    public void reset()
    {
        dead = false;
        GetComponent<MeshRenderer>().enabled = true;
    }
}
