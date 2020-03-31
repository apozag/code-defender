using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    Enemy[] enemies;
    Goal goal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void findElements()
    {
        enemies = FindObjectsOfType<Enemy>();
        goal = FindObjectOfType<Goal>();
    }

    public bool isGoalComplete()
    {
        bool complete = true;

        if (enemies != null)
        {
            foreach (Enemy e in enemies)
            {
                if (!e.isDead())
                    complete = false;
            }
        }

        if (goal != null)
        {
            if (!goal.isPlayerOn())
                complete = false;
        }

        //resetElements();

        return complete;
    }

    public void resetElements()
    {
        if (goal != null)
            goal.reset();

        if (enemies != null)
        {
            foreach (Enemy e in enemies)
                e.reset();
        }

    }
}
