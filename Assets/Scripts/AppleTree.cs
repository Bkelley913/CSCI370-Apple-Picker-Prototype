using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update
    
    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 1f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    // Change that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;

    // Rate at which Apples will be instatiated
    public float secondsBetweenAppleDrops = 1f;
    void Start()
    {
        // Dropping apples every second
        Invoke( "DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>( applePrefab );
        apple.transform.position = transform.position;
        Invoke( "DropApple", secondsBetweenAppleDrops );
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if ( pos.x < -leftAndRightEdge )
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if ( pos.x > leftAndRightEdge )
        {
            speed = -Mathf.Abs(speed); // Move left
        }
        else if ( Random.value < chanceToChangeDirections )
        {
            speed *= -1; // Change direction
        }
    }

    void FixedUpdate()
    {
        // Changing Direction Randomly is now time-based because of FixedUpdate()
        if ( Random.value < chanceToChangeDirections )
        {
            speed *= -1; // Change directin
        }
    }
}
