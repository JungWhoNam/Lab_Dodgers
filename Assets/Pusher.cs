using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public float pushForce = 10f;

    void OnCollisionEnter(Collision collision)
    {
        // 부딪친 게임 오브젝트 이름
        string name = collision.gameObject.name;
        // 부딪친 게임 오브젝트의 RigidBody 컴포넌트
        Rigidbody rb = collision.rigidbody;
        // 부딪친 부분의 법선벡터 (그림 참조)
        Vector3 normalVector = collision.GetContact(0).normal;      

        if (name.Equals("Capsule") && rb != null)
        {
            rb.AddForce(-normalVector * pushForce, ForceMode.Impulse);
        }
    }
}
