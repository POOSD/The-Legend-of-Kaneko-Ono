using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class movementTest : MonoBehaviour
{
   [UnityTest]
   public IEnumerator movementTest()
   {
       // Generate a ship object
        GameObject shipObject1 = new GameObject();
        GameObject shipObject2 = new GameObject();
        shipObject1.AddComponent<enemyMovement>();
        shipObject2.AddComponent<enemyMovement>();

        shipObject1.position.transform.x = -1;
        shipObject1.position.transform.y = 1;
        shipObject1.position.transform.z = 0;

        shipObject2.position.transform.x = 0;
        shipObject2.position.transform.y = 0;
        shipObject2.position.transform.z = 0;
        shipObject2.valueX = -1;
        shipObject2.valueY = 1;

        shipObject2.Move();

        Assert.AreEqual(shipObject1.position.transform, shipObject2.position.transform);

}
