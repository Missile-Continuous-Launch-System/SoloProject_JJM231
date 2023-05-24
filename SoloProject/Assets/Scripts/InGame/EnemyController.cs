using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    //public Transform head; // 적의 머리를 나타내는 Transform
    public float followDistance = 2f; // 적이 플레이어를 따라가는 거리
    public float rotationSpeed = 5f; // 적의 머리 회전 속도
    NavMeshAgent nav;
    public Animator anit;
    public Transform Player;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        anit = GetComponent<Animator>();
    }
    private void start(){
        
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        
        // 플레이어와의 거리가 followDistance보다 크면 적이 이동
        if (distance > followDistance)
        {
            nav.SetDestination(target.position);
        }
        else
        {
            anit.SetTrigger("Attack");
        }

        // 적이 플레이어를 바라보도록 회전
        this.transform.LookAt(Player);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Arrow"))
        {
            Destroy(gameObject);
        }
    }
}
