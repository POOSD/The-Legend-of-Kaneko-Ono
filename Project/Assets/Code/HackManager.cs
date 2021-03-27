using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackManager : MonoBehaviour
{
    public List<ShipComponent> hackables;
    public int howManyHacked, totalComponentCount;
    public GameObject player;
    public bool isOriginal;

    void getHackables()
    {
        // hackNext() will hack in the order these are added
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

    // Start is called before the first frame update
    void Start()
    {
        isOriginal = (hackables.Capacity == 0);
        if (isOriginal) {
            howManyHacked = 0;
            totalComponentCount = 0;
            getHackables();
        }
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == player)
        {
            Debug.Log("Oops, look like you've been hacked!");
            hackNext();
        }
    }
}
