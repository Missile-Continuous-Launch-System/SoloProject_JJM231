using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject bombFactory;
    public float firepower = 15f;
    public float bombLifetime = 3f;
    public float damageAmount = 10f; // 적에게 입힐 피해량

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine(FireBomb());
        }
        if (Input.GetButtonDown("Fire1"))
        {
            FireGun();
        }
    }

    IEnumerator FireBomb()
    {
        GameObject bomb = Instantiate(bombFactory);
        bomb.transform.rotation = firePosition.transform.rotation;
        bomb.transform.position = firePosition.transform.position;

        Rigidbody ri = bomb.GetComponent<Rigidbody>();
        ri.AddForce(firePosition.transform.forward * firepower, ForceMode.Impulse);

        yield return new WaitForSeconds(bombLifetime);

        Destroy(bomb);
    }

    void FireGun()
    {
        RaycastHit hit;
        if (Physics.Raycast(firePosition.transform.position, firePosition.transform.forward, out hit))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                // 적에게 피해를 입히는 로직을 여기에 추가
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(damageAmount);
                }
            }
        }
    }
}
