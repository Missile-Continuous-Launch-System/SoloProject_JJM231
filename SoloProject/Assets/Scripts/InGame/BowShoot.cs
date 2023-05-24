using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowShoot : MonoBehaviour
{
    public GameObject arrowPrefab;       // 활을 발사할 화살 프리팹
    public Transform arrowSpawnPoint;    // 화살이 발사될 위치
    public float arrowSpeed = 10f;       // 화살 발사 속도

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootArrow();
        }
    }

    private void ShootArrow()
    {
        GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
        Rigidbody arrowRigidbody = arrow.GetComponent<Rigidbody>();
        arrowRigidbody.velocity = arrowSpawnPoint.forward * arrowSpeed;
    }
}
