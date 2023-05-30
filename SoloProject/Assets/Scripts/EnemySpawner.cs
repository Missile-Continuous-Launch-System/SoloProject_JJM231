using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 캐릭터 프리팹
    public Transform[] spawnPoints; // 스폰 위치 배열
    public float minSpawnInterval = 1f; // 최소 스폰 간격
    public float maxSpawnInterval = 3f; // 최대 스폰 간격

    private float timer; // 스폰 타이머
    private float spawnInterval; // 스폰 간격

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        // 타이머 업데이트
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnEnemy(); // 적 캐릭터 스폰
            ResetTimer(); // 타이머 초기화
        }
    }

    private void ResetTimer()
    {
        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        timer = spawnInterval;
    }

    private void SpawnEnemy()
    {
        // 랜덤한 스폰 위치 선택
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        // 적 캐릭터 스폰
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
