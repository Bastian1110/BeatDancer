using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem.instance.health += 0.16f;
            HUDSystem.instance.UpdateHealth();
            Destroy(gameObject, 1f);
            audio.Play();
        }
    }
}
