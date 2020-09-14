using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_animation : MonoBehaviour
{
    public Sprite sprite0;
    public Sprite sprite1; 
    public Sprite sprite2; 
    script_control moveScript;
    SpriteRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<script_control>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveScript.moving)
        {
            if (Mathf.Round(Time.fixedTime) % 2 == 0)
            {
                myRenderer.sprite = sprite1;
            }
            else
            {
                myRenderer.sprite = sprite2;
            }
        }
        else {
            myRenderer.sprite = sprite0;
        }
    }
}
