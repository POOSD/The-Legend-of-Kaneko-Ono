using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private Vector3 destination;
    private Vector3 currentPoint;
    float min = 0.0f, max = 5.0f;
    public float valueX, valueY;
    private float moveSpeed = 0.5f;
    public int pointSelection;
    //public GameObject enemy;
    private normalShot enemyHealth;
    //private bool issue = true;
    private bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = this.GetComponent<normalShot>();
        currentPoint = this.transform.position;
        //enemy = GameObject.FindWithTag("Enemy");
        //this.transform.position = currentPoint;
        valueX = UnityEngine.Random.Range(min, max);
        valueY = UnityEngine.Random.Range(min, max);
        destination = new Vector3(valueX, valueY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // 
        if (currentPoint != destination) {
            moving = true;
        }

        if (moving) {
            Move();  
            
        }
        
    }

    public void Move()
    {
        
        this.transform.position = Vector3.MoveTowards(currentPoint, destination, Time.deltaTime * moveSpeed);

        currentPoint = this.transform.position;

        if (this.transform.position == destination) {
            currentPoint = this.transform.position;
            valueX = UnityEngine.Random.Range(min, max);
            valueY = UnityEngine.Random.Range(min, max);
            destination = new Vector3(valueX, valueY, 0); 
            moving = false;
        }
    }
}
