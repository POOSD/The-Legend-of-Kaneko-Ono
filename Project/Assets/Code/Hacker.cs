using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public GameObject player = GameObject.Find("player");
    public GameObject manager = GameObject.Find("HackManager");
    public bool hackTimer = false;
    public float hackDeadline;

    void Update() {
        if (hackTimer && Time.time >= hackDeadline) {
            
        }
    }
    void OnTriggerEnter2D(Collider2D whatWasHit) {
        if (player == whatWasHit)
            hackTimer = true;
    }
    void OnTriggerExit2D(Collider2D whatWasGone) {
        if (player == whatWasGone) {
            hackDeadline = Time.time + 10.0f;
            hackTimer = false;
        }
    }
}