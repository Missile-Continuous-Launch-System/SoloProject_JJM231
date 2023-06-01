using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private AudioSource aaa;
    public Animator animator;
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
            StartCoroutine(Die());
        }
    }

    IEnumerator Die(){
        animator.SetTrigger("Hit");
        yield return new WaitForSeconds(1.2f);
        Destroy(gameObject);
    }
}
