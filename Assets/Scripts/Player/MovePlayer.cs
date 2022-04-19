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
    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
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

        //Animation
        float velocity = Mathf.Abs(rb.velocity.x);
        anim.SetBool("isMoving", velocity > 0.1);

        //Direction
        render.flipX = rb.velocity.x < 0;


    }
}
