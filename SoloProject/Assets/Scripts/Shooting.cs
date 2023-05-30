using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform gunEnd; 
    private AudioSource audioSource;
    public AudioClip shot;
    public AudioClip head;

    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))  // 마우스 왼쪽 버튼 등을 사용하여 발사
        {
            Shoot();
            audioSource.PlayOneShot(shot);
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(gunEnd.position, gunEnd.forward, out hit))
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);

            if (hit.collider.tag == "Enemy")
            {
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(25);  // 몸 부위에 25 데미지 입히기
                }
            }
            else if (hit.collider.tag == "Head")
            {
                EnemyHealth enemyHealth = hit.collider.transform.root.GetComponent<EnemyHealth>();
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage(100);
                    audioSource.PlayOneShot(head);  // 머리 부위에 100 데미지 입히기
                }
            }
        }
    }
}
