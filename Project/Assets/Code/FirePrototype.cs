using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePrototype : MonoBehaviour
{
   public Transform firePoint;
   public GameObject normalShot_prefab;

   // Update is called once per frame
   void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         Shoot();
      }
   }

   void Shoot()
   {
      Instantiate(normalShot_prefab, firePoint.position, firePoint.rotation);
   }
}
