using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDLifeSystem : MonoBehaviour
{
    public static HUDLifeSystem instance;

    public Image healthBar;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateHealth()
    {
        float health = HealthSystem.instance.health;
        healthBar.fillAmount = health;
    }
}
