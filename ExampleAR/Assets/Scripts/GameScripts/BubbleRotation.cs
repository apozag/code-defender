using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleRotation : MonoBehaviour
{
    //Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        //camera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        //transform.Rotate(new Vector3(0, 180, 0), Space.Self);
    }
    private void OnEnable()
    {
        transform.LookAt(Camera.main.transform);
    }
}
