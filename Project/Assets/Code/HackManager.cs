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
    public GameObject player;
    public float unhackRegenTime = 0.0f;

    void getHackables()
    {
        // hackNext() will hack in the order these are added
        // add stuff here when you want to add things to be hacked
        var player = GameObject.Find("player");
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
        for (int i = hackables.Capacity - 1; i >= 0; i++)
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
        getHackables();
        player = GameObject.FindWithTag("Player");
    }
}
