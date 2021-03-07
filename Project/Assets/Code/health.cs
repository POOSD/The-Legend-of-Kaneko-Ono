using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public float curHealth = 100.0f;
    public float regen = 5.0f;
    public int damage = 25;
    public float healthBarLength;
    public GameObject player;
    public bool isRegenerating = false;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = 10;
        healthBarLength = Screen.width / 2;
        AdjustCurrentHealth();
    }

    public void AdjustCurrentHealth()
    {
        if (curHealth <= 0)
        {
            curHealth = 0;
        }

        if (curHealth > maxHealth)
        {
            curHealth = 80;
        }

        if (curHealth < 80)
        {
            curHealth += regen * Time.smoothDeltaTime;
        }

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (isRegenerating)
        {
            AdjustCurrentHealth();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        isRegenerating = true;
        //player.TakeDamage(damage);
        //curHealth -= damage;
    }
    
}
