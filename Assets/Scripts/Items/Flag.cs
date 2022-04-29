using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject winPanel;
    public AudioSource audio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Win.instance.UpdateStats();
            winPanel.SetActive(true);
            Time.timeScale = 0;
            audio.Play();
        }
    }
}
