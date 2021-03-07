using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSpawn : MonoBehaviour
{

    public int side;
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate=2f;
    float nextSpawn=0.0f;


    public Transform currentSpawner;
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject newEnemy;
        newEnemy = Instantiate(enemy, currentSpawner) as GameObject;*/
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
            {
                nextSpawn=Time.time + spawnRate;
                //drone is enemy
                if(side==0)
                {
                randX=Random.Range(0.0f,9.0f);
                }
                else //drone is ally
                {
                randX=Random.Range(-9.0f,0.0f);
                }
                whereToSpawn=new Vector2(randX,transform.position.y);
                Instantiate(enemy,whereToSpawn,Quaternion.identity);

            }
    }
}
