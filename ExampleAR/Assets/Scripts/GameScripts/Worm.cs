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

    ElementsManager elemManager;

    TextMeshPro counter;

    int currentTurns = 0;

    public bool original = true;

    bool dead = false;

    bool doomed = false;

    // Start is called before the first frame update
    void Start()
    {

        counter = bubble.GetComponentInChildren<TextMeshPro>();

        elemManager = FindObjectOfType<ElementsManager>();

        currentTurns = 0;

        counter.SetText(turns.ToString());

        if (!active)
        {
            GetComponentInChildren<Renderer>().material = transparentMaterial;
            bubble.SetActive(false);
        }
        else
        {
            replicate();
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
                bubble.SetActive(false);
            }
            if(!active)
            {
                activate();
            }
            currentTurns = 0;
        }

        if(active)
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
        if (doomed)
        {
            die();
        }
        else
        {
            GetComponentInChildren<Renderer>().material = opaqueMaterial;

            active = true;
            bubble.SetActive(true);
            replicate();
        }
    }


    public bool isDead()
    {
        return dead;
    }

    void replicate()
    {
        left = Instantiate(this, transform.parent);
        right = Instantiate(this, transform.parent);

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
            left.transform.Translate(new Vector3(-0.1f, 0, 0), Space.Self);
            right.transform.Translate(new Vector3(0.1f, 0, 0), Space.Self);
        }
        else
        {
            left.transform.Translate(new Vector3(0, 0, -0.1f), Space.Self);
            right.transform.Translate(new Vector3(0, 0, 0.1f), Space.Self);
        }

        elemManager.addWorm(left);
        elemManager.addWorm(right);

    }

    public void reset()
    {
        gameObject.SetActive(true);
        activate();
        dead = false;
        currentTurns = 0;
        updateCounter();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            if (active)
            {
                die();
            }
            else
            {
                doomed = true;
            }
            
        }
        
    }

    private void die()
    {
        if (left != null && !left.active)
        {
            elemManager.worms.Remove(left);
            Destroy(left.gameObject);
        }
        if (right != null && !right.active)
        {
            elemManager.worms.Remove(right);
            Destroy(right.gameObject);
        }

        if (original)
        {
            dead = true;
            gameObject.SetActive(false);
        }
        else
        {
            elemManager.worms.Remove(this);
            Destroy(this.gameObject);
        }
    }

}
