using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 1f; // 최대 체력
    private float currentHealth; // 현재 체력

    private void Start()
    {
        currentHealth = maxHealth; // 시작 시 체력을 최대 체력으로 초기화
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount; // 피해량만큼 체력 감소

        if (currentHealth <= 0)
        {
            Die(); // 체력이 0 이하이면 사망 처리
        }
    }

    private void Die()
    {
        // 적이 사망할 때 수행할 동작을 여기에 작성
        // 예를 들면 사망 애니메이션 재생, 점수 증가 등을 수행할 수 있습니다.
        Destroy(gameObject); // 적 오브젝트를 제거
    }
}
