using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_control : MonoBehaviour
{
    public float speed = 1f;
    public Boolean moving = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moving = false;
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(0, speed* Time.deltaTime, 0);
            moving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
            moving = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            moving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            moving = true;
        }
    }
}
