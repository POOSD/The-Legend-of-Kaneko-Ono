using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalShot : MonoBehaviour
{
   public float speed = 5f;
   public int damage = 50;
   public Rigidbody2D rigidBody;
   public GameObject impactEffect;

   // Start is called before the first frame update
   void Start()
   {
      rigidBody.velocity = transform.right * speed;
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
      Debug.Log(hitInfo.name);
      Enemy enemy = hitInfo.GetComponent<Enemy>();
      if (enemy != null)
      {
        enemy.TakeDamage(damage);
      }

      Instantiate(impactEffect, transform.position, transform.rotation);

      Destroy(gameObject);
   }
}
