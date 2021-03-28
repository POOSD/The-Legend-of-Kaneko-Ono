using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject deathEffect;
    public HealthBar healthBar;

    public void TakeDamage(int damage)
    {
        health -= damage;

        // update health bar
        healthBar.SetHealth(health);

        if (health <= 0)
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
