using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void Update()
    {
        Transform transform = GetComponent<Transform>();
        transform.Rotate(new Vector3(0, 1, 0), 5);
    }

    void OnTriggerEnter(Collider other)
    {
        // �ε�ģ ���� ������Ʈ �̸�
        string name = other.gameObject.name;
        // �ε�ģ ���� ������Ʈ�� �±�
        string tag = other.tag;

        Debug.Log("�ε�ħ: " + name + " " + tag);

        if (name.Equals("Capsule"))
        {
            gameObject.SetActive(false);
        }
    }
}
