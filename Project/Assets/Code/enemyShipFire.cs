using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipFire : ShipComponent
{
   public Transform firePoint;
   public GameObject enemyBullet_prefab;
   public float previousTime;
   public float deltaTime;
   public float delayTime;

    void Start()
    {
        componentName = "Enemy Primary Guns";
        isActive = true;
    }

    // Update is called once per frame
    void Update()
   {
      deltaTime += Time.time - previousTime;
      if (deltaTime >= delayTime)
      {
        Shoot();
        deltaTime = 0;
      }
      previousTime = Time.time;
   }

   void Shoot()
   {
      Instantiate(enemyBullet_prefab, firePoint.position, firePoint.rotation); //create our bullet       
   }
}