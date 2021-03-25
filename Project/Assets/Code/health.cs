using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//trigger script
public class health : MonoBehaviour
{
    public int maxHealth = 100;
    public float curHealth = 100.0f;
    public float regen = 5.0f;
    public GameObject player;
    public bool isRegenerating = false;
    public bool isDead = false;
    public bool damaged = false;
    public RectTransform healthBarRect;

    // Start is called before the first frame update
    void Start()
    {
        healthBarRect = healthBarRect.GetComponent<RectTransform>();
        healthBarRect.sizeDelta = new Vector2(100, 25);
        AdjustCurrentHealth();
    }

    public void AdjustCurrentHealth()
    {
        if (curHealth <= 0)
        {
            curHealth = 0;
             // kill the player
            Destroy(player);
            FindObjectOfType<gameManager>().gameOver("lose");
        }

        if (curHealth > maxHealth)
        {
            curHealth = 80;
        }

        if (curHealth < 80)
        {
            curHealth += regen * Time.smoothDeltaTime;
            healthBarRect.sizeDelta = new Vector2(curHealth, healthBarRect.sizeDelta.y);
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
        curHealth -= amount;
    }
    
}
