using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Script to handle the representation of Katsby  in the HUD

public class HUDSystem : MonoBehaviour
{
    public static HUDSystem instance;
    public Image healthBar;
    public TextMeshProUGUI fishesText;
    public AudioSource audio;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateHealth()
    {
        float health = HealthSystem.instance.health;
        healthBar.fillAmount = health;
        audio.Play();
    }

    public void UpdateFishes()
    {
        int fishes = FishSystem.instance.fishes;
        fishesText.text = fishes.ToString();
    }
}
