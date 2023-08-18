using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Range(1, 5)]
    [SerializeField] private float _spawnDelay = 1f;
    [SerializeField] private GameObject _enemyPrefab;

    private void Start()
    {
        StartCoroutine(EnemySpawning(_spawnDelay));
    }

    IEnumerator EnemySpawning(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            
            float spawnY = UnityEngine.Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = UnityEngine.Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
            
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(_enemyPrefab, spawnPosition, quaternion.identity);
        }
    }
}
