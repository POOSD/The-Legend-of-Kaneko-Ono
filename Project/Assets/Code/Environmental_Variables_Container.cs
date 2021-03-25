using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environmental_Variables_Container : MonoBehaviour
{
    public int numberPlayerCharacters;
    public int numberEnemyCharacters;
    public static int numberEnemiesKilled;
    public int score;
    public int difficulty;
    DateTime startTime;
    DateTime currentTime;
    public float velocityModifier;
    public float driftModifier;
    public float scrollSpeed;
    public bool playerVulnerability;
    public bool bossVulnerability;


    // Start is called before the first frame update
    void Start()
    {
        numberPlayerCharacters = 0;
        numberEnemyCharacters = 0;
        numberEnemiesKilled=0;
        score = 0;
        // difficulty = getDifficulty();
        startTime = System.DateTime.Now;
        velocityModifier = 0;
        driftModifier = 0;
        // scrollSpeed = getScrollSpeed();
        playerVulnerability = false;
        bossVulnerability = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(numberEnemiesKilled>=25)
        {
        FindObjectOfType<gameManager>().gameOver("win");
        }

    }
}
