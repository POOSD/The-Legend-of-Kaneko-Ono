/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class normalFireShot : MonoBehaviour
{
   public float speed = 5f;
   private float damage = 10.0f;
   public Rigidbody2D rigidBody;
   //public GameObject impactEffect;
   public float curHealth;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = 100;
        rigidBody.velocity = transform.right * speed;
    }
    void Update()
    {
        if (curHealth <= 0)
        {
            // kill the enemy
            Destroy(gameObject);
        }
    }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
      Debug.Log(hitInfo.name);
      Enemy enemy = hitInfo.GetComponent<Enemy>();
      if (enemy != null)
      {
        enemy.TakeDamage(damage);
      }

      //Instantiate(impactEffect, transform.position, transform.rotation);
   }
}
*/