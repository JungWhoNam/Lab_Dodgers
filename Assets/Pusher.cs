using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public float pushForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
        // �ε�ģ ���� ������Ʈ �̸�
        string name = collision.gameObject.name;
        // �ε�ģ ���� ������Ʈ�� RigidBody ������Ʈ
        Rigidbody rb = collision.rigidbody;
        // �ε�ģ �κ��� �������� (�׸� ����)
        Vector3 normalVector = collision.GetContact(0).normal;      

        if (name.Equals("Capsule") && rb != null)
        {
            rb.AddForce(-normalVector * pushForce, ForceMode.Impulse);
        }
    }
}
