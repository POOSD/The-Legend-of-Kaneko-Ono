using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
  // Start is called before the first frame update
    public void Play()
    {
    Debug.Log("Start Game...");
    SceneManager.LoadScene("Working_Demo");
    }
    public void Quit()
    {
      
    Debug.Log("Quit!");
    Application.Quit();
    }
}
