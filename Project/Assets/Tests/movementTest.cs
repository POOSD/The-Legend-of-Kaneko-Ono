using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class movementTest : MonoBehaviour
{
   [UnityTest]
   public IEnumerator movementTestOne()
   {
       // Generate a ship object
        GameObject shipObject1 = new GameObject();
        GameObject shipObject2 = new GameObject();
        shipObject1.AddComponent<enemyMovement>();
        shipObject2.AddComponent<enemyMovement>();

        shipObject1.GetComponent<Transform>().position = new Vector3(-1, 1, 0);
        shipObject2.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        
        shipObject2.GetComponent<enemyMovement>().valueX = -1;
        shipObject2.GetComponent<enemyMovement>().valueY = 1;

        shipObject2.GetComponent<enemyMovement>().Move();

        Assert.AreEqual(shipObject1.GetComponent<Transform>().transform, shipObject2.GetComponent<Transform>().transform);

        yield return null;
   }
}
