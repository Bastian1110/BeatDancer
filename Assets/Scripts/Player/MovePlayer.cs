using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script to move the player
//By Sebastian Mora
public class MovePlayer : MonoBehaviour
{
    //Speed
    public float speed;
    public float jump;

    //RigidBody
    Rigidbody2D rb;
    SpriteRenderer render;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //Horizontal Movement
        float movH = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movH * speed, rb.velocity.y);

        //Jump
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(FloorTrigger.grounded == true)
            {
                //rb.velocity = new Vector2(rb.velocity.x, jump);
                rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            }
        }
    }
}
