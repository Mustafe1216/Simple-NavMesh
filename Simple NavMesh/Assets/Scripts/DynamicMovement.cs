using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicMovement : MonoBehaviour
{
    public float speed = 2f; // speed of movement
    public float distance = 3f; // distance to move in each direction

    private float startingX; // starting x position of obstacle

    void Start()
    {
        startingX = transform.position.x; // get starting x position of obstacle
    }

    void Update()
    {
        float newPosition = Mathf.PingPong(Time.time * speed, distance) + startingX; // calculate new position
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z); // set new position
    }
}