// Daniel Trimble
// COP4331 - Principles of Object Oriented Software Development
// Group 5, Sprint #2
// 12 Feb 2021

// This script requires that some Collider 2D as well as a Rigidbody 2D components be added to the
//    asset. In addition the Rigidbody should be configured as "Kinematic" as well as the 
//    "Simulated" and Use "Full Kinematic Contacts" checkboxes be selected. Everything else can be
//    set to defaults.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movementHorizontal;
    public float movementVertical;
    public float driftVelocity;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the amount of drift after movement key is released.
        // 0.85 is a magic number but "felt" good.
        driftVelocity = 0.9f;
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal and Vertical movement get reduced each frame by 15%
        // This allows for a slight drift effect allowing a less artificial feel.
        // Additionally this effect gradually reduces movement each frame to zero if the player
        //    isn't holding a movement key down.
        movementHorizontal *= driftVelocity;
        movementVertical *= driftVelocity;

        // Upward Movement Logic
        if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W))
        {
            movementVertical += 0.75f;
        }
        // Downward Movement Logic
        if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S))
        {
            movementVertical -= 0.75f;
        }
        // Leftward Movement Logic
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            movementHorizontal -= 0.75f;
        }
        // Rightward Movement Logic
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            movementHorizontal += 0.75f;
        }

        // Sets the velocity field each frame to move the character.
        GetComponent<Rigidbody2D> ().velocity = new Vector2 (movementHorizontal, movementVertical);
    }
}