using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipFire : ShipComponent
{
   public Transform firePoint;
   public Transform curPosition;
   public GameObject enemyBullet_prefab;
   public float shootingTime;
   public float fireRate = 1000f; // fire every 3 seconds
   public float shootingPower = 20f;

    void Start()
    {
        componentName = "Enemy Primary Guns";
        isActive = true;
    }

    // Update is called once per frame
    void Update()
   {
        Shoot();
   }

   void Shoot()
   {
       if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000; //set the local var. to current time of shooting
            Vector2 myPos = new Vector2(curPosition.position.x, curPosition.position.y); //our curr position is where our muzzle points
            GameObject projectile = Instantiate(enemyBullet_prefab, firePoint.position, firePoint.rotation); //create our bullet
            Vector2 direction = (Vector2)firePoint.position - myPos; //get the direction to the target
            projectile.GetComponent<Rigidbody2D>().velocity = direction * shootingPower; //shoot the bullet
        }
        
   }
}
