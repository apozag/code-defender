using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Worm : MonoBehaviour
{

    [SerializeField] GameObject bubble;

    [SerializeField] Material opaqueMaterial;
    [SerializeField] Material transparentMaterial;

    Worm left, right;

    [SerializeField] int turns = 3;

    [SerializeField] bool horizontal = true;

    [SerializeField] bool active = true;

    TextMeshPro counter;

    bool replicated = false;

    int currentTurns = 0;

    bool original = true;

    // Start is called before the first frame update
    void Start()
    {

        counter = bubble.GetComponentInChildren<TextMeshPro>();

        counter.SetText(turns.ToString());

        if (!active)
        {
            GetComponentInChildren<Renderer>().material = transparentMaterial;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateTurn()
    {
        currentTurns++;
        if(currentTurns >= turns)
        {
            if (active)
            {
                if (!replicated)
                {
                    replicate();
                }
            }
            else
            {
                activate();
            }
            currentTurns = 0;
        }

        if(active && !replicated)
        {
            updateCounter();
        }
    }

    void updateCounter()
    {
        counter.SetText((turns - currentTurns).ToString());
    }

    void activate()
    {
        GetComponentInChildren<Renderer>().material = opaqueMaterial;
       
        active = true;
        bubble.SetActive(true);
    }

    void replicate()
    {
        left = Instantiate(this);
        right = Instantiate(this);

        left.turns = turns;
        right.turns = turns;

        left.horizontal = !horizontal;
        right.horizontal = !horizontal;

        left.active = false;
        right.active = false;

        left.original = false;
        right.original = false;

        if (horizontal)
        {
            left.transform.Translate(transform.right * -0.1f);
            right.transform.Translate(transform.right * 0.1f);
        }
        else
        {
           left.transform.Translate(transform.forward * -0.1f);
           right.transform.Translate(transform.forward * 0.1f);
        }

        bubble.SetActive(false);

        replicated = true;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(active && other.gameObject.tag == "Player")
        {
            if (left != null && !left.active)
            {
                Destroy(left.gameObject);
            }
            if (right != null && !right.active)
            {
                Destroy(right.gameObject);
            }

            if (original)
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Worm>() != null)
        {
            Destroy(gameObject);
        }
    }
}
