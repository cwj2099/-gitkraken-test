using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Script_camera : MonoBehaviour
{
    public GameObject traction;
    float dx = 0;
    float dy = 0;
    // Start is called before the first frame update
    void Start()
    {
        traction = GameObject.Find("player");
        dx = traction.transform.position.x - transform.position.x;
        dy = traction.transform.position.y - transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, traction.transform.position.x - dx, 5 * Time.deltaTime),
            Mathf.Lerp(transform.position.y, traction.transform.position.y - dy, 5 * Time.deltaTime),
            transform.position.z);
    }
}
