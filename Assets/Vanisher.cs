using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanisher : MonoBehaviour
{
    public int maxJumps = 3;
    public int jumpCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            jumpCount += 1;
            if (jumpCount >= maxJumps)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
