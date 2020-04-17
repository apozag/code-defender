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
        foreach(Worm worm in worms)
        {
            if (worm != null)
            {
                worm.updateTurn();
            }
            
        }

        foreach(Worm worm in FindObjectsOfType<Worm>())
        {
            if (!worms.Contains(worm))
                worms.Add(worm);
        }
    }
}
