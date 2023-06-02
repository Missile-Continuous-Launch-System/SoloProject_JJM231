using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject bombFactory;
    public float firepower = 15f;
    public float bombLifetime = 3f;

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            StartCoroutine(FireBomb());
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
}
