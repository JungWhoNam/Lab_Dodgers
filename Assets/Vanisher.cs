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
            // Color c = new Color(1, 0, 0, 1); // ������
            // Color c = new Color(0, 1, 0, 1); // ���
            // Color c = new Color(0, 0, 1, 1); // �Ķ���
            // Color c = new Color(0, 0, 1, 0.5f); // �������� �Ķ��� 
            Color c = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            material.color = c;

            jumpCount += 1;
            if (jumpCount >= maxJumps)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
