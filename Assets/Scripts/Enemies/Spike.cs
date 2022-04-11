using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Spike Enemi Script
//Only to test if health system works
public class Spike : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HealthSystem.instance.health -= 0.16f;
            HUDLifeSystem.instance.UpdateHealth();
        }
    }

}
