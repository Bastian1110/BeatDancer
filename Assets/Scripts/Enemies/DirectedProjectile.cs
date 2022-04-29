using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to handlde projectile behaviour
//By Sebastian Mora
public class DirectedProjectile : MonoBehaviour
{
    public float speed;
    public AudioSource audio;
    public AudioSource audiodead;

    private Transform player;
    private Vector2 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem.instance.health -= 0.16f;
            HealthSystem.instance.DamageAnimation();
            HUDSystem.instance.UpdateHealth();
            if(HealthSystem.instance.health < 0)
            {
                HealthSystem.instance.KatsbyDeath();
                audiodead.Play();
            }
        audio.Play();
        }
    }
}
