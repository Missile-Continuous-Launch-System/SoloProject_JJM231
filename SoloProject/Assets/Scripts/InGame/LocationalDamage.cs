// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class LocationalDamage : MonoBehaviour {

//   // The damage multipliers for each body part.
//   public float headDamageMultiplier = 1.5f;
//   public float bodyDamageMultiplier = 1.0f;
//   public float armDamageMultiplier = 0.85f;
//   public float legDamageMultiplier = 0.85f;

//   // The collider that represents the enemy's body.
//   private Collider bodyCollider;

//   // The collider that represents the enemy's head.
//   private Collider headCollider;

//   // The colliders that represent the enemy's arms.
//   private Collider[] armColliders;

//   // The colliders that represent the enemy's legs.
//   private Collider[] legColliders;

//   // The collider that was hit by the last shot.
//   private Collider hitCollider;

//   // The damage that was dealt to the enemy by the last shot.
//   private float damageDealt;

//   // The function that is called when the enemy is shot.
//   void OnCollisionEnter(Collision collision) {
//     // Check if the enemy was hit in the head.
//     if (collision.collider == headCollider) {
//       damageDealt = damage * headDamageMultiplier;
//     }
//     // Check if the enemy was hit in the body.
//     else if (collision.collider == bodyCollider) {
//       damageDealt = damage * bodyDamageMultiplier;
//     }
//     // Check if the enemy was hit in the arm.
//     else if (armColliders.Contains(collision.collider)) {
//       damageDealt = damage * armDamageMultiplier;
//     }
//     // Check if the enemy was hit in the leg.
//     else if (legColliders.Contains(collision.collider)) {
//       damageDealt = damage * legDamageMultiplier;
//     }

//     // Deal damage to the enemy.
//     enemy.TakeDamage(damageDealt);

//     // Set the collider that was hit by the last shot.
//     hitCollider = collision.collider;
//   }

//   // The function that is called every frame.
//   void Update() {
//     // If the enemy is dead, destroy it.
//     if (enemy.isDead) {
//       Destroy(gameObject);
//     }

//     // If a collider was hit by the last shot, play a hit effect.
//     if (hitCollider != null) {
//       Instantiate(hitEffect, hitCollider.transform.position, hitCollider.transform.rotation);
//     }
//   }
// }

