using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class hackingTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void GeneralHackingTest()
    {
        var hackerman = new GameObject().AddComponent<HackManager>();
        Assert.AreEqual(hackerman.totalComponentCount, 2);
        /*
        Assert.AreEqual(hackerman.howManyHacked, 0);
        hackerman.hackNext();
        Assert.AreEqual(hackerman.howManyHacked, 1);
        hackerman.hackNext();
        Assert.AreEqual(hackerman.howManyHacked, 2);
        hackerman.hackNext();
        Assert.AreEqual(hackerman.howManyHacked, 2);
        */
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator hackingTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
