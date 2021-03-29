using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int currentHealth;
    public int maximumHealth;
    public GameObject deathEffect;
    public HealthBar healthBar;

   void Start()
   {
      currentHealth = maximumHealth;
   }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // update health bar
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

        //update environment variables accordingly
        Environmental_Variables_Container.numberEnemiesKilled += 1;
        Environmental_Variables_Container.numberEnemyCharacters -= 1;
    }
}
