
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalShot : MonoBehaviour
{
   public float speed = 100f;
   public int damage = 50;
   public Rigidbody2D rigidBody;
   public GameObject impactEffect;
   private int curHealth;

   // Start is called before the first frame update
   void Start()
   {
      curHealth = 100;
      rigidBody.velocity = transform.right * speed;
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
      Enemy enemy = hitInfo.GetComponent<Enemy>();
<<<<<<< HEAD

=======
      if(enemy != null){
>>>>>>> e3f6096cef3fb34feb7974a712f38fc82103bad2
      if (enemy.health > 0)
      {
         enemy.TakeDamage(damage);
         curHealth -= damage;
      }

      Debug.Log(enemy.name + " " + damage + " " + enemy.health);
        

      Instantiate(impactEffect, transform.position, transform.rotation);

      Destroy(gameObject);
      }
   }
}