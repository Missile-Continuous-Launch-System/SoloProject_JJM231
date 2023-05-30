using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private AudioSource aaa;
    public int maxHealth = 100;  // 최대 체력
    private int currentHealth;  // 현재 체력

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // 적이 사망한 경우에 수행할 동작 구현
        Destroy(gameObject);
        
    }
}
