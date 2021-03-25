// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public void gameOver(string s){
        Debug.Log("GAME OVER");

        //if player health is 0, then this function is called with string "lose"
        if(s=="lose")
        {
        SceneManager.LoadScene("LOSESCREEN");
        }

        //if number of killed players is 25, then this function is called with "win"
        if(s=="win")
        {
        SceneManager.LoadScene("WINSCREEN");
        }
    }
}
