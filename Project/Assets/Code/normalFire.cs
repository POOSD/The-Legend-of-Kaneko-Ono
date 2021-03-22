using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalFire : MonoBehaviour
{
   public float speed = 0f;
   public int damage = 0;
   public Rigidbody2D rigidBody;
   //public GameObject impactEffect;
   public float curHealth;

   // Start is called before the first frame update
   void Start()
   {
      curHealth = 100;
      rigidBody.velocity = transform.right * speed;
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
      Debug.Log(hitInfo.name);
      Enemy enemy = hitInfo.GetComponent<Enemy>();
      if (enemy != null)
      {
        enemy.TakeDamage(damage);
        curHealth -= damage;
      }

      //Instantiate(impactEffect, transform.position, transform.rotation);

      Destroy(gameObject);
   }
}
