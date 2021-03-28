using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Volume
{
    // A Test behaves as an ordinary method
    [Test]
    public void VolumeSimplePasses()
    {
        // Use the Assert class to test conditions

        var music= new GameObject().AddComponent<AudioSource>();

        Assert.AreEqual(1f,music.volume);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator VolumeWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.

        yield return new WaitForFixedUpdate();
        var music= new GameObject().AddComponent<AudioSource>();
        yield return new WaitForFixedUpdate();

        //check that volume variable changes at all
        Assert.IsTrue(1f<music.volume);

    }
}
