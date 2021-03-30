using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHealth : MonoBehaviour
{
    public GameObject player;
    private health playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerHealth = player.GetComponent<health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collid)
    {
        if(collid.gameObject == player) {
            Debug.Log("Found the player in triggerHealth.OnTriggerEnter2D().");
            playerHealth.isRegenerating = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collid)
    {
        if(collid.gameObject == player)
            playerHealth.isRegenerating = false;
    }
}
