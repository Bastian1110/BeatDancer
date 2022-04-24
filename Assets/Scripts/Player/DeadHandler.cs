using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadHandler : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Update()
    {
        if(HealthSystem.instance.health < 0.1)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
        
    }
}
