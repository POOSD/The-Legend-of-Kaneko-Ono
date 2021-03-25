using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPrototype : ShipComponent
{
   public Transform firePoint;
   public GameObject normalShot_prefab;
   public GameObject Fire_prefab;

    void Start()
    {
        componentName = "Primary Guns";
        isActive = true;
    }

    // Update is called once per frame
    void Update()
   {
      if (Input.GetButtonDown("Fire1") && isActive)
      {
         Shoot();
      }
   }

   void Shoot()
   {
      Instantiate(normalShot_prefab, firePoint.position, firePoint.rotation);
      //Instantiate(Fire_prefab, firePoint.position, firePoint.rotation);
   }
}
