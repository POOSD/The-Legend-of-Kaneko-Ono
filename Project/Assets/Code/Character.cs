using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject character;
    public Transform objectToSpawn;
    void Spawn()
    {
        Start();
        Update();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject newCharacter;
        newCharacter=Instantiate(character,objectToSpawn) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
