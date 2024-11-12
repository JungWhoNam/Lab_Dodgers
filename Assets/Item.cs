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
        // 부딪친 게임 오브젝트 이름
        string name = other.gameObject.name;
        // 부딪친 게임 오브젝트의 태그
        string tag = other.tag;

        Debug.Log("부딪침: " + name + " " + tag);

        if (name.Equals("Capsule"))
        {
            gameObject.SetActive(false);
        }
    }
}
