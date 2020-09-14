using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class script_spacebar : MonoBehaviour
{
    public int myScore = 0;
    public int vic = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            myScore++;
        }
        //victory check
        if (myScore >= vic) {
            print("Victory achived");
        }
    }
}
