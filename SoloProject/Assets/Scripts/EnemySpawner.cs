using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 캐릭터 프리팹
    public Transform[] spawnPoints; // 적 캐릭터 스폰 지점들
    public float spawnInterval = 2.0f; // 적 캐릭터 스폰 간격

    private float timer;

    private void Start()
    {
        timer = spawnInterval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnEnemy();
            timer = spawnInterval;
        }
    }

    private void SpawnEnemy()
    {
        int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomSpawnIndex];

        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}

