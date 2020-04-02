using UnityEngine;
using System.Collections.Generic;

public enum Turn
{
    RIGHT,
    LEFT
}

public class PlayerMovement : MonoBehaviour
{
    GameObject floor;

    Vector3 v = new Vector3(0, 0, 0);

    Vector3 moved = new Vector3(0, 0, 0);

    readonly float stepSize = 0.1f;
    readonly float speed = 1.5f;

    //posiciones en distintos niveles
    static Dictionary<string, Vector3> levelPositions = new Dictionary<string, Vector3>() {
        {"51", new Vector3(0.35f, 0.05f, 0.05f)},
        {"61", new Vector3(0.45f, 0.05f, -0.45f)}
    };

    Vector3 initPos;
    Quaternion initRot;

    //State
    bool isRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.FindGameObjectWithTag("Floor");

        string topicLevel = PlayerPrefs.GetString("TOPIC") + PlayerPrefs.GetString("LEVEL");

        if (levelPositions.ContainsKey(topicLevel))
        {
            transform.localPosition = levelPositions[topicLevel];
        }

        transform.forward.Set(floor.transform.forward.x, floor.transform.forward.y, floor.transform.forward.z);

        initPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        initRot = new Quaternion(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z, transform.localRotation.w);
        
    }

    // Update is called once per frame
    void Update()
    {
        //step
        if (isRunning)
        {
            if (moved.magnitude < v.magnitude)
            {
                Vector3 dist = v * Time.deltaTime * speed;
                moved += dist;
                transform.position = transform.position + dist;
            }
            else
            {
                isRunning = false;
            }
        }
    }

    public void step(int steps)
    {
        v = transform.forward * steps * stepSize;
        moved = new Vector3(0, 0, 0);

        isRunning = true;
    }

    public void turn(Turn t)
    {
        switch (t)
        {
            case Turn.RIGHT:
                transform.Rotate(new Vector3(0, 90, 0));
                break;
            case Turn.LEFT:
                transform.Rotate(new Vector3(0, -90, 0));
                break;
        }
    }

    public bool ready()
    {
        return !isRunning;
    }

    public void reset()
    {
        transform.localPosition = initPos;
        transform.localRotation = initRot;
    }

}
