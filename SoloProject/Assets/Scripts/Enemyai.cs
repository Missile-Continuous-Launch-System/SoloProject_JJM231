    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.AI;

    public class Enemyai : MonoBehaviour
    {   
        //public AudioClip die;  // 총 소리 클립

        private AudioSource audioSource;

        Rigidbody ri;
        NavMeshAgent nav;
        public float distance;
        public Transform target;

        public Animator ani;
        // Start is called before the first frame update
        void Start()
        {
            nav = GetComponent<NavMeshAgent>();

            ri = GetComponent<Rigidbody>();
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            if (Vector3.Distance(target.position, transform.position) > distance){
                
                nav.SetDestination(target.position);

            } 
            else{
                ani.SetTrigger("Attack");
                 
            }
        }
    }
