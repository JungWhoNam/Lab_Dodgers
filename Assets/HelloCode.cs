using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody rb;

    void Start()
    {
        Debug.Log("½ºÅ¸Æ®");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        rb.velocity = new Vector3(xSpeed, 0, zSpeed);
    }
}
