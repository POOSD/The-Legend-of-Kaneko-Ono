using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class makeObjectTest
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator makeObjectTestWithEnumeratorPasses()
    {
        // This recreates the enemy drone object
        GameObject drone = new GameObject();
        drone.AddComponent<RectTransform>();
        drone.AddComponent<SpriteRenderer>();
        drone.AddComponent<playerDamage>();
        drone.AddComponent<enemyMovement>();
        drone.AddComponent<Enemy>();
        drone.AddComponent<CanvasRenderer>();
        drone.AddComponent<Canvas>();
        drone.AddComponent<CircleCollider2D>();
        drone.AddComponent<boundedbox>();
        drone.AddComponent<Hacker>();

        yield return null;

        // Modify components to desired value
        /*
        var x = drone.GetComponent<RectTransform>().transform.position.x;

        yield return null;

        // Test that drone works as desired part A.
        drone.doThisThing();

        bool thingDoesThing = drone.GetComponent<yadayada>().DoThis();

        drone.moveToPosition();

        yield return new WaitForSeconds(3);

        Assert.IsTrue(drone.getPosition() == here);

        // Part B
        */
    }
}
