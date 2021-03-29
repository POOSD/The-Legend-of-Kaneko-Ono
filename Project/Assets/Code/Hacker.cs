using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    public GameObject player;
    public HackManager manager;
    void Start() {
        player = GameObject.FindWithTag("Player");
        manager = GameObject.Find("GameManager").GetComponent<HackManager>();
    }
    void OnTriggerEnter2D(Collider2D whatWasHit) {
        if (player == whatWasHit.gameObject) {
            Debug.Log("Yep, that's the player!");
            manager.howManyHacking++;
        }
    }
    void OnTriggerExit2D(Collider2D whatWasGone) {
        if (player == whatWasGone.gameObject) {
            Debug.Log("Yep, that was the player.");
            manager.howManyHacking--;
        }
    }
}