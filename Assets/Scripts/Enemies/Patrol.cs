using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for testing, I'm still not sure
//it's the best solution
//Script to make an enemy patrol a plattaform
//Using a ray
//By Sebastian Mora
public class Patrol : MonoBehaviour
{
    public float walkSpeed;
    public float groundRayDistance;
    public float wallRayDistance;

    private bool moveRight = true; //Direction of enemy

    public Transform groundDetector;
    public Transform wallDetector;

    private bool collition = false;


    //Waiting System
    public float waitTime = 1f;
    private float waitCounter = 0f;
    private bool waitState = false;

    private void Update()
    {
        if (waitState)
        {
            waitCounter += Time.deltaTime;
            if (waitCounter < waitTime)
                return;
            waitState = false;
        }

        transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);

        if (!collition)
        {
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetector.position, Vector2.down, groundRayDistance);
            RaycastHit2D wallInfo = Physics2D.Raycast(wallDetector.position, transform.right, wallRayDistance);
            if (!groundInfo.collider || wallInfo.collider)
            {
                waitState = true;
                waitCounter = 0f;
                collition = true;
            }

        }
        if(collition && !waitState)
        {
            if (moveRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveRight = true;
            }
            collition = false;
        }
    }
}
