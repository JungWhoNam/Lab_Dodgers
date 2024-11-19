using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    [Tooltip("Ȯ�� ���� Ʈ������")]
    [SerializeField] private Transform playerTransform;

    [Tooltip("���� ��ε��Ǵ� Ʈ�������� y �� ����")]
    [SerializeField] private float yThreshold = -5f;

    void Update()
    {
        if (playerTransform.position.y < yThreshold)
        {
            Scene scene = SceneManager.GetActiveScene();
            string sceneName = scene.name;
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }   
    }
}
