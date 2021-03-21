using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class VolumeToggleTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void VolumeSimplePasses()
    {
        // Commented out - maybe dont need
        // var music= new GameObject().AddComponent<AudioSource>();
        // var listen= new GameObject().AddComponent<AudioListener>();

        // // Use the Assert class to test conditions
        // SceneManager.LoadScene("MainMenuScene",LoadSceneMode.Additive);
        // //yield return new WaitForSeconds(10f);
        // Assert.IsTrue(1f>music.volume);
        // //Assert.AreEqual(1f,music.volume);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator VolumeToggleTestWithEnumeratorPasses()
    {
        SceneManager.LoadScene("MainMenuScene",LoadSceneMode.Additive);
        // var listen= new GameObject().AddComponent<AudioListener>();
        // GameObject.Destroy(listen);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        var music= new GameObject().AddComponent<AudioSource>();

        yield return new WaitForSeconds(10f);

        //VolumeToggle.Start();

        yield return new WaitForSeconds(10f);

        //VolumeToggle.updateVolume(0.5f);

        Debug.Log(music.volume);

        //check that volume variable changes at all
        Assert.IsTrue(1f>music.volume);

    }
}
