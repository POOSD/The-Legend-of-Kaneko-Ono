using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
      Debug.Log("Start Game...");
      SceneManager.LoadScene("Working_Demo");
   }

   public void QuitGame()
   {
      Debug.Log("Quit!");
      Application.Quit();
   }
}
