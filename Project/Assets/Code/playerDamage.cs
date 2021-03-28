using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public float attackDamage = 25.0f;
    float timer;
    public GameObject player;
    private health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerHealth = player.GetComponent<health>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            Attack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (playerHealth.curHealth <= 0)
        {
            // kill the player
            Destroy(gameObject);
            FindObjectOfType<gameManager>().gameOver("lose");
        }
    }

    void Attack()
    {
        timer = 0f;
        if (playerHealth.curHealth > 0)
        {
            playerHealth.TakeDamage(attackDamage);
        }
    }
}
