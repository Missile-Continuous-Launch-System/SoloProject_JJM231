using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Booom : MonoBehaviour
{
    public GameObject bombEffect;
    public LayerMask collisionLayer;

    private void OnCollisionEnter(Collision collision){
        if (collisionLayer == (collisionLayer | (1 << collision.gameObject.layer)))
        {
            Explode();
        }
    }
    // Start is called before the first frame update
    private void Explode(){
        GameObject eff = Instantiate(bombEffect);

        eff.transform.position = transform.position;
        Destroy(gameObject);

    }
    
}
