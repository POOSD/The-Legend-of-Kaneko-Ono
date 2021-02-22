using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform currentSpawner;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newEnemy;
        newEnemy = Instantiate(enemy, currentSpawner) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
