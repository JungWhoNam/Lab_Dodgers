using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reloader : MonoBehaviour
{
    [Tooltip("확인 중인 트랜스폼")]
    [SerializeField] private Transform playerTransform;

    [Tooltip("씬이 재로딩되는 트랜스폼의 y 값 설정")]
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
