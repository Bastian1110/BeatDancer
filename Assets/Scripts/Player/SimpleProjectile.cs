using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleProjectile : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadX = 5;

    private SpriteRenderer renndererProyectil;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(velocidadX, 0);
        renndererProyectil = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

}
