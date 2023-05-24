using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowbowbow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Dess());
    }
    IEnumerator Dess(){
        yield return new WaitForSeconds( 4.5f );
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Ground")){
            Destroy(gameObject);
        }
    }
}
