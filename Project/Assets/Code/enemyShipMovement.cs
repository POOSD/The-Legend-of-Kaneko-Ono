using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipMovement : MonoBehaviour
{
    private Vector3 destination;
    private Vector3 currentPoint;
    private float moveSpeed = 0.5f;
    private bool moving = false;
    public float offsetPositionX = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentPoint = this.transform.position;
        destination = new Vector3(this.transform.position.x - offsetPositionX, this.transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoint != destination) {
            moving = true;
        }

        if (moving) {
            Move();  
            
        }
    }

    void Move()
    {
        this.transform.position = Vector3.MoveTowards(currentPoint, destination, Time.deltaTime * moveSpeed);
        currentPoint = this.transform.position;
        if (this.transform.position == destination) {
            currentPoint = this.transform.position;
            destination = new Vector3(this.transform.position.x - offsetPositionX, this.transform.position.y, 0);
            moving = false;
        }
    }
}
