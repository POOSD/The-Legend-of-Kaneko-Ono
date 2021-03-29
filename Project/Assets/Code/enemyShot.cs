using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShot : MonoBehaviour
{
   public float speed = 100f;
   public int damage = 50;
   public Rigidbody2D rigidBody;
   public GameObject impactEffect;

   // Start is called before the first frame update
   void Start()
   {
        rigidBody.velocity = transform.right * speed;
        Destroy(gameObject, 10);
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
        health health = hitInfo.GetComponent<health>();
        if (health != null){
            if (health.currentHealth > 0)
            {
                health.TakeDamage(damage);
            }

            Debug.Log(health.name + " " + damage + " " + health.currentHealth);

            var impact = Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(gameObject);
            Destroy(impact, 1);
        }
   }
}