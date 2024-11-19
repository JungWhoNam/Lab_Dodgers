using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private Vector3 offset;

    void Start()
    {
        // �÷��̾� ��ġ���� ���� ������Ʈ ��ġ�� ����Ű�� ����
        offset = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 pos = playerTransform.position + offset;
        transform.position = pos;
    }
}
