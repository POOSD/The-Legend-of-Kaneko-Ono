using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
   public int health = 100;
   public GameObject deathEffect;
   public RectTransform healthBarRect;



//healthBarRect.sizeDelta = new Vector2(0.96f, 0.19f);

//healthBarRect.sizeDelta = new Vector2(0.96f - (curHealth / 100), healthBarRect.sizeDelta.y);

   public void TakeDamage(int damage)
   {
      health -= damage;

      if (health <= 0)
      {
         Die();
      }
   }

   void Die()
   {
      Instantiate(deathEffect, transform.position, Quaternion.identity);
      Destroy(gameObject);
      Environmental_Variables_Container.numberEnemiesKilled+=1;
   }

//    internal void TakeDamage(float damage)
//    {
//        throw new NotImplementedException();
//    }
}
