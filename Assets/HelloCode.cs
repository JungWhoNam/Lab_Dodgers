using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public float jumpForce = 12;
    public float speed = 0.5f;
    public int maxJumps = 2;

    public ParticleSystem ps;

    private Rigidbody rb;
    private int jumpCount = 0;
    
    void Start()
    {
        Debug.Log("½ºÅ¸Æ®");
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (jumpCount < maxJumps && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);
            rb.AddForce(force, ForceMode.Impulse);

            jumpCount = jumpCount + 1;
        }

        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        if (xInput != 0 || zInput != 0)
        {
            float xSpeed = xInput * speed;
            float zSpeed = zInput * speed;

            if (Input.GetKey(KeyCode.LeftControl))
            {
                xSpeed *= 2f;
                zSpeed *= 2f;
            }

            //rb.velocity = new Vector3(xSpeed, 0, zSpeed);
            //rb.AddForce(new Vector3(xSpeed, 0, zSpeed), ForceMode.Impulse);
            Vector3 velocity = new Vector3(xSpeed, 0, zSpeed);
            Vector3 pos = rb.position + velocity;
            rb.MovePosition(pos);
        }      
    }

    void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.name.Equals("Plane"))
        if (collision.gameObject.CompareTag("Ground"))
        {
            //Debug.Log("On Ground");
            jumpCount = 0;

            ps.transform.position = collision.GetContact(0).point;
            ps.Play();
        }
    }

}
