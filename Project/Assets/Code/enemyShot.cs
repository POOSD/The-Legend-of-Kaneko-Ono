
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShot : MonoBehaviour
{
   public float speed = 100f;
   public int damage = 50;
   public Rigidbody2D rigidBody;
   public GameObject impactEffect;
   public int health;

   // Start is called before the first frame update
   void Start()
   {
        health = 100;
        rigidBody.velocity = transform.right * speed;
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null){
            if (player.health > 0)
            {
                player.TakeDamage(damage);
                health -= damage;
            }

            Debug.Log(player.name + " " + damage + " " + player.health);

            Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }
   }
}