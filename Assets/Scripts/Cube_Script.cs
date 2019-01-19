using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Script : MonoBehaviour
{
    private float x = 0.20f;
    private float y = 0.20f;
    private float z = 0.20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale += new Vector3(x, y, z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale += new Vector3(-x, -y, -z);
        }
    }
}
