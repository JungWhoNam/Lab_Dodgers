using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public float jumpForce = 6;
    public float speed = 10;
    private Rigidbody rb;

    void Start()
    {
        Debug.Log("��ŸƮ");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);
            rb.AddForce(force, ForceMode.Impulse);
        }

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        if (xInput != 0 || zInput != 0)
        {
            float xSpeed = xInput * speed;
            float zSpeed = zInput * speed;

            //rb.velocity = new Vector3(xSpeed, 0, zSpeed);
            //rb.AddForce(new Vector3(xSpeed, 0, zSpeed), ForceMode.Impulse);
            Vector3 velocity = new Vector3(xSpeed, 0, zSpeed);
            Vector3 pos = rb.position + velocity;
            rb.MovePosition(pos);
        }      
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Plane"))
        {
            Debug.Log("On Ground");
        }
    }

}
