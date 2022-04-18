using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private SpriteRenderer render;

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!render.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
