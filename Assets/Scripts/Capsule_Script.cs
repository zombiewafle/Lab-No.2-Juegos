using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_Script : MonoBehaviour
{

    public float frequency = 1f;
    public float amp = 0.5f;
    private Vector3 movement = new Vector3();
    private Vector3 temporalPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        movement = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        temporalPosition = movement;
        temporalPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amp;
        transform.position = temporalPosition;
    }
}
