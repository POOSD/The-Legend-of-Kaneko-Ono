using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class mainMenuTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void mainMenuTestSimplePasses()
    {
        // Use the Assert class to test conditions

        //check that start game button pressed

        //if yes, check that window changed to the working demo scene



    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator mainMenuTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.


        yield return null;
    }
}
