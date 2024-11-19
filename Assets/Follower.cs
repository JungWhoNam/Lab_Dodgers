using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset;

    void Start()
    {
        // 플레이어 위치에서 현재 오브젝트 위치를 가르키는 벡터
        offset = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 pos = playerTransform.position + offset;
        transform.position = pos;
    }
}
