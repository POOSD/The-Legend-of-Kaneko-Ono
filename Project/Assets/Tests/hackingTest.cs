using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class hackingTest
{

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator hackingTestWithEnumeratorPasses()
    {
        // Generate a ship object
        GameObject shipObject = new GameObject();

        var primaryGuns = new GameObject().AddComponent<WeaponPrototype>();
        var thrusters = new GameObject().AddComponent<Player_Movement>();
        var hackerman = new GameObject().AddComponent<HackManager>();

        shipObject.AddComponent<WeaponPrototype>();
        shipObject.AddComponent<Player_Movement>();

        yield return null;

        Assert.AreEqual(hackerman.totalComponentCount, 0);
        hackerman.hackables.Add(GameObject.Find("player").GetComponent<Player_Movement>());
        Assert.AreEqual(hackerman.totalComponentCount, 1);
        hackerman.hackables.Add(GameObject.Find("player").GetComponent<WeaponPrototype>());
        Assert.AreEqual(hackerman.totalComponentCount, 1);

        Assert.AreEqual(hackerman.howManyHacked, 0);
        // hackerman.hackNthPiece(0);
        // Assert.AreEqual(hackerman.howManyHacked, 1);
        yield return null;
    }
}
