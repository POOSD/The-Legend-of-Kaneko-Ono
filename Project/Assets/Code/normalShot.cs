using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalShot : MonoBehaviour
{
   public float speed = 100f;
   public int damage = 50;
   public Rigidbody2D rigidBody;
   public GameObject impactEffect;

   // Start is called before the first frame update
   void Start()
   {
      rigidBody.velocity = transform.right * speed;
      Destroy(gameObject, 2);
   }

   void OnTriggerEnter2D(Collider2D hitInfo)
   {
      Enemy enemy = hitInfo.GetComponent<Enemy>();
      if(enemy != null){
        if (enemy.health > 0)
        {
           enemy.TakeDamage(damage);
        }

      Debug.Log(enemy.name + " " + damage + " " + enemy.health);


      var impact = Instantiate(impactEffect, transform.position, transform.rotation);

      Destroy(gameObject);
      Destroy(impact, 1);
      }
   }
}
