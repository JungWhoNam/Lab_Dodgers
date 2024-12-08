using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vanisher : MonoBehaviour
{
    private Material material;

    public int maxJumps = 3;
    public int jumpCount = 0;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            jumpCount += 1;
            
            Color c = new Color(1, 1, 1, 1);

            c.a = (float) (maxJumps - jumpCount) / maxJumps;

            material.color = c;

            Debug.Log("Max Jumps: " + maxJumps + ", Jump Count: " + jumpCount + ", Alpha: " + c.a);

            if (jumpCount >= maxJumps)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
