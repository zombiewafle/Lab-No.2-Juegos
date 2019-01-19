using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrangeForm_Script : MonoBehaviour
{
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Input.GetKey(KeyCode.R))
            {
                transform.Rotate(0, 0, 10);
            }
            else
            {
                if (Input.GetKey(KeyCode.T))
                {
                    transform.Rotate(0, 10, 0);
                }

            }
        }
        else
        {
            transform.Rotate(10, 0, 0);
        }
        
        
    }
}
