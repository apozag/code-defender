using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    ElementsManager elemManager;

    // Start is called before the first frame update
    void Start()
    {
        elemManager = FindObjectOfType<ElementsManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    public bool isGoalComplete()
    {
        bool complete = true;

        if (elemManager.enemies != null)
        {
            foreach (Enemy e in elemManager.enemies)
            {
                if (!e.isDead())
                {
                    complete = false;
                    break;
                }
            }
        }
        if(elemManager.worms != null)
        {
            foreach(Worm worm in elemManager.worms)
            {
                if (!worm.isDead())
                {
                    complete = false;
                    break;
                }
            }
        }

        if (elemManager.goal != null)
        {
            if (!elemManager.goal.isPlayerOn())
                complete = false;
        }

        resetElements();

        return complete;
    }

    public void resetElements()
    {
        if (elemManager.goal != null)
            elemManager.goal.reset();

        if (elemManager.enemies != null)
        {
            foreach (Enemy e in elemManager.enemies)
                e.reset();
        }

        if(elemManager.worms != null)
        {
            elemManager.resetWorms();
        }

    }
}
