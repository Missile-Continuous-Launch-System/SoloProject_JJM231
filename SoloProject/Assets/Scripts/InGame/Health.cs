using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

  public float health;

  public void TakeDamage(float damageAmount) {
    health -= damageAmount;
    if (health <= 0) {
      Debug.Log("DIE");
    }
  }
}
