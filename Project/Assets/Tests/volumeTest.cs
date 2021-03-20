using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class volumeTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void volumeTestSimplePasses()
    {

        var music= new GameObject().AddComponent<AudioSource>();

        Assert.AreEqual(1f,music.volume);
        

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator volumeTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        // Use the Assert class to test conditions
        yield return null;

        var music= new GameObject().AddComponent<AudioSource>();

        //check that volume variable changes at all
        Assert.IsTrue(1f<music.volume);

        yield return null;
    }
}
