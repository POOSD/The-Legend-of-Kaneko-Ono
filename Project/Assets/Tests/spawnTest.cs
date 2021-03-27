using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class spawnTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void spawnTestSimplePasses()
    {
        // Use the Assert class to test conditions
        var environ = new GameObject().AddComponent<Environmental_Variables_Container>();
        var spawner = new GameObject().AddComponent<droneSpawner>();
        spawner.side = 0;

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator spawnTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
