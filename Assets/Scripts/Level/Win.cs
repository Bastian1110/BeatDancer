using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI fishText;
    public TextMeshProUGUI killText;
    public TextMeshProUGUI timerText;

    public static Win instance;

    private DateTime initialTime;
    TimeSpan playTimeRough;

    private void Awake()
    {
        instance = this;
        initialTime = DateTime.Now;
    }
    public void UpdateStats()
    {
        int fishes = FishSystem.instance.fishes;
        DateTime finalTime = DateTime.Now;
        playTimeRough = finalTime - initialTime;
        fishText.text = fishes.ToString();
        timerText.text = "Time : " +  playTimeRough.ToString(@"mm\:ss");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
