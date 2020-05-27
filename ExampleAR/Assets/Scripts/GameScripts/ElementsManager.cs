using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsManager : MonoBehaviour
{


    public List<Enemy> enemies;
    public List<Worm> worms;
    public Goal goal;

    // Start is called before the first frame update
    void Start()
    {
        findElements();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void findElements()
    {
        enemies = new List<Enemy>(FindObjectsOfType<Enemy>());
        worms = new List<Worm>(FindObjectsOfType<Worm>());
        goal = FindObjectOfType<Goal>();
    }

    public void updateTurn()
    {
        for(int i = 0; i < worms.Count; i++)
        {
            if (worms[i] != null)
            {
                worms[i].updateTurn();
            }
        }
    }

    public void resetWorms()
    {
        List<Worm> toRemove = new List<Worm>();
        List<int> resetIndexes = new List<int>();
    
        for(int i = 0; i < worms.Count; i++)
        {
            if (worms[i].original)
            {
                resetIndexes.Add(i);
            }
            else
            {
                toRemove.Add(worms[i]);
            }
        }

        foreach(int i in resetIndexes)
        {
            worms[i].reset();
        }

        foreach(Worm worm in toRemove)
        {
            worms.Remove(worm);
            Destroy(worm.gameObject);
        }
    }
    
    public void addWorm(Worm worm)
    {
        worms.Add(worm);
    }
}
