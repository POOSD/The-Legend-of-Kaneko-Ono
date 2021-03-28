using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackManager : MonoBehaviour
{
    public List<ShipComponent> hackables;
    public int howManyHacked = 0;
    public int howManyHacking = 0;
    public int totalComponentCount = 0;
    public float hackTime = 3.0f;
    public float unhackTime = 3.0f;
    public GameObject player;
    public float hackDegenTime = 0.0f;
    public float unhackRegenTime = 0.0f;

    void getHackables()
    {
        // hackNext() will hack in the order these are added
        // add stuff here when you want to add things to be hacked
        hackables.Add(player.GetComponent<WeaponPrototype>());
        hackables.Add(player.GetComponent<Player_Movement>());

        foreach (ShipComponent piece in hackables)
        {
            totalComponentCount++;
            piece.isActive = true;
        }

    }

    void Add(ShipComponent sc)
    {
        if (!hackables.Contains(sc))
        {
            hackables.Add(sc);
            totalComponentCount++;
        }
    }

    void hackNthPiece(int n)
    {
        if (n < totalComponentCount && hackables[n].isActive)
        {
            hackables[n].isActive = false;
            howManyHacked++;
        }
        
    }

    void hackNext()
    {
        foreach (ShipComponent piece in hackables)
        {
            if (piece.isActive)
            {
                piece.isActive = false;
                howManyHacked++;
                break;
            }
        }
    }
// for the regen mechanic
    void unHackMostRecent() {
        for (int i = totalComponentCount - 1; i >= 0; i--)
        {
            if(!hackables[i].isActive)
            {
                hackables[i].isActive = true;
                howManyHacked--;
                break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        hackDegenTime = 0.0f;
        unhackRegenTime = 0.0f;
        player = GameObject.FindWithTag("Player");
        getHackables();
    }

    void Update() {
        if (howManyHacking > 0 && howManyHacked < totalComponentCount) { // hacking
            Debug.Log("Hacking in progress");
            if(hackDegenTime == 0.0f) { // means the timer didn't start yet
                hackDegenTime = Time.time + hackTime;
                unhackRegenTime = 0.0f;
            } else if (Time.time >= hackDegenTime) { // the timer's done
                hackNext();
                if (howManyHacked < totalComponentCount) { // not done hacking
                    hackDegenTime = Time.time + hackTime; // so we reset the timer
                } else { // done hacking
                    hackDegenTime = 0.0f; // doesn't have to happen
                } // just wanted to set it to 0.0f just in case :P
            }
        } else if (howManyHacked != 0) { // regenning
            if (unhackRegenTime == 0.0f) { // again, timer didn't start yet
                unhackRegenTime = Time.time + unhackTime;
                hackDegenTime = 0.0f; // this stops the degen timer
            } else if (Time.time >= unhackRegenTime) { // timer's done
                unHackMostRecent();
                if (howManyHacked > 0) {// not done unhacking
                    unhackRegenTime = Time.time + unhackTime;
                } else { // done regenning
                    unhackRegenTime = 0.0f;
                }
            }
        }
    }
}
