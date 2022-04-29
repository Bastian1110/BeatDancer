using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FishSystem.instance.fishes++;
            HUDSystem.instance.UpdateFishes();
            Destroy(gameObject, 0.1f);
        }
    }
}
