using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneSpawner : MonoBehaviour
{

    public int side;
    public GameObject enemy;
    float randX;
    float randY;
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

                var playerPos=GameObject.Find("player").transform.position;

                //drone is enemy
                if(side==0)
                {
                randX=Random.Range(playerPos.x+6.0f,playerPos.x+9.0f);
                }
                else //drone is ally
                {
                randX=Random.Range(playerPos.x-0.5f,playerPos.x+0.5f);
                }
                randY=Random.Range(-1.85f,1.85f);
                whereToSpawn=new Vector2(randX,randY);

                if(enemy != null){
                    
                    Instantiate(enemy,whereToSpawn,Quaternion.identity);
                    Environmental_Variables_Container.numberEnemyCharacters+=1;

                }

            }
    }
}