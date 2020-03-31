using UnityEngine;
using System.Collections.Generic;

public enum Turn
{
    RIGHT,
    LEFT
}

public enum Direction
{
    NORTH,
    EAST,
    SOUTH,
    WEST
}

public class PlayerMovement : MonoBehaviour
{
    GameObject floor;

    Direction dir;

    Vector3 v = new Vector3(0, 0, 0);

    Vector3 moved = new Vector3(0, 0, 0);

    float stepSize = 0.1f;

    float speed = 1.5f;

    float initHeight;

    //posiciones en distintos niveles
    static Dictionary<string, Vector3> levelPositions = new Dictionary<string, Vector3>() {
        {"51", new Vector3(0.355f, 0.05f, 0.05f)},
        {"61", new Vector3(0.45f, 0.05f, -0.45f)}
    };

    //TODO:: quitar esto
    Vector3 initPos;
    Quaternion initRot;
    Transform initTransform;

    //State
    //bool isJumping = false;
    bool isRunning = false;

    bool isReady = true;

    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.FindGameObjectWithTag("Floor");

        dir = Direction.NORTH;
        //stepSize = floor.GetComponent<MeshRenderer>().bounds.size.x / 10;

        //transform.parent.position = floor.transform.position;

        string topicLevel = PlayerPrefs.GetString("TOPIC") + PlayerPrefs.GetString("LEVEL");

        if (levelPositions.ContainsKey(topicLevel))
        {
            transform.localPosition = levelPositions[topicLevel];
        }

        transform.forward = floor.transform.forward;

        initHeight = transform.position.y;

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
                isReady = true;
            }
        }
    }

    public void step(int steps)
    {
        v = transform.forward * steps * stepSize;
        moved = new Vector3(0, 0, 0);

        isRunning = true;
        isReady = false;
    }

    public void turn(Turn t)
    {
        switch (t)
        {
            case Turn.RIGHT:

                transform.Rotate(new Vector3(0, 90, 0));
                dir += 1;

                break;
            case Turn.LEFT:
                transform.Rotate(new Vector3(0, -90, 0));
                dir -= 1;
                break;
        }

        if (dir > Direction.WEST)
            dir = Direction.NORTH;
        else if (dir < Direction.NORTH)
            dir = Direction.WEST;
    }

    public void jump()
    {
        v = transform.forward * stepSize;
        moved = new Vector3(0, 0, 0);

        //isJumping = true;
        isReady = false;
    }

    public bool ready()
    {
        return isReady;
    }

    public void reset()
    {
        transform.localPosition = initPos;
        transform.localRotation = initRot;
    }

}
