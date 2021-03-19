using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class boundstest
{
    // A Test behaves as an ordinary method
    [Test]
    public void boundstestSimplePasses()
    {
        // Use the Assert class to test conditions
        var player1 = new GameObject().AddComponent<health>();
        Assert.AreEqual(player1.maxHealth, 100);

        var player2 = new GameObject().AddComponent<Enemy>();
        Assert.AreEqual(player2.health, 100);

        player1.TakeDamage(20);
        Assert.IsTrue(player2.health < 100);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    // [UnityTest]
    // public IEnumerator boundstestWithEnumeratorPasses()
    // {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        // yield return null;
    // }
}
