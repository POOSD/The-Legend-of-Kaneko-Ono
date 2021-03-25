using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalShot : MonoBehaviour
{
   public float speed = 5f;
   public int damage = 25;
   //public Rigidbody2D rigidBody;
   //public GameObject impactEffect;
   public float curHealth;
   public RectTransform healthBarRect;
   public GameObject enemy;


    // Start is called before the first frame update
    void Start()
   {
       enemy = GameObject.FindWithTag("Enemy");
       healthBarRect.sizeDelta = new Vector2(0.96f, 0.19f);
       curHealth = 100;
       //rigidBody.velocity = transform.right * speed;
   }
    public void TakeDamage(float amount)
    {
        // current health decreases by the damage value
        curHealth -= amount;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
   {
        Debug.Log(hitInfo.name);
        //Enemy enemy = hitInfo.GetComponent<Enemy>();
        TakeDamage(damage);
        healthBarRect.sizeDelta = new Vector2(0.96f - (curHealth / 100), healthBarRect.sizeDelta.y);
        if (curHealth <= 0 && enemy != null)
        {
            Destroy(gameObject);
        }

      //Instantiate(impactEffect, transform.position, transform.rotation);

      // 
   }
}
