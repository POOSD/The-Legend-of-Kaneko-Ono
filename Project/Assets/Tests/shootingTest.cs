using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class shootingTest : MonoBehaviour
{
   [UnityTest]
   public IEnumerator shootingTestBasic()
   {
        // Generate a player object
        GameObject thePlayer = new GameObject();
        GameObject theChildFiringPoint = new GameObject();
        theChildFiringPoint.transform.parent = thePlayer.transform;
		theChildFiringPoint.transform.localPosition = Vector3.zero;
        thePlayer.AddComponent<WeaponPrototype>();
        

        yield return null;
   }
}
