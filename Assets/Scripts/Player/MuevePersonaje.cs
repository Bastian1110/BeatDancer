using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    //Velocidades
    public float velocidadX = 0;
    public float velocidadY = 0;

    //RigidBody
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Caminar
        float movHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movHorizontal*velocidadX, rb.velocity.y);

        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
    }
}
