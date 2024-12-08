using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public Rigidbody rb;

    void OnTriggerEnter()
    {
        rb.useGravity = true;
    }
}
