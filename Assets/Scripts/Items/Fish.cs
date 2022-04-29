using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public AudioSource audio;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FishSystem.instance.fishes++;
            HUDSystem.instance.UpdateFishes();
            Destroy(gameObject, 1f);
            audio.Play();
        }
    }



}
