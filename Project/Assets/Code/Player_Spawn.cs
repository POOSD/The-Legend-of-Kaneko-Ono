using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawn : MonoBehaviour
{
    public GameObject target;
    public Transform creator;
    // Start is called before the first frame update
    void Start()
    {
        GameObject replicant;
        replicant = Instantiate(target, creator) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
