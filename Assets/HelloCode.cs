using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        Debug.Log("½ºÅ¸Æ®");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, -speed);
        }

    }
}
