using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public int health = 100;
   public GameObject deathEffect;

   public HealthBar healthBar;

//healthBarRect.sizeDelta = new Vector2(0.96f, 0.19f);

//healthBarRect.sizeDelta = new Vector2(0.96f - (curHealth / 100), healthBarRect.sizeDelta.y);

   public void TakeDamage(int damage)
   {
      health -= damage;
      healthBar.SetHealth(health);

      if (health <= 0)
      {
         Die();
      }
   }

   void Die()
   {
      Instantiate(deathEffect, transform.position, Quaternion.identity);

      //update environment variables accordingly
   }

//    internal void TakeDamage(float damage)
//    {
//        throw new NotImplementedException();
//    }
}
