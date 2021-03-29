using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trigger script
public class health : MonoBehaviour
{
    public float maximumHealth;
    public float currentHealth;
    public float regen = 5.0f;
    public GameObject player;
    public bool isRegenerating = false;
    public bool isDead = false;
    public bool damaged = false;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        // set healthbar
        currentHealth = maximumHealth;
        healthBar.SetMaxHealth(maximumHealth);
        AdjustCurrentHealth();
    }

    public void AdjustCurrentHealth()
    {
        if (currentHealth <= 0.0f)
        {
            currentHealth = 0.0f;
             // kill the player
            Destroy(player);
            FindObjectOfType<gameManager>().gameOver("lose");
        }

        if (currentHealth < 96.0f)
        {
            currentHealth += regen * Time.smoothDeltaTime;
            
            // update health bar
            healthBar.SetHealth(currentHealth);
        }

    }

    // Update is called once per frame
    void Update()
    {
        damaged = false;
        if (isRegenerating)
        {
            AdjustCurrentHealth();
        }

    }
    public void TakeDamage(float amount)
    {
        damaged = true;
        // current health decreases by the damage value
        currentHealth -= amount;

        // update health bar
        healthBar.SetHealth(currentHealth);
    }

}
