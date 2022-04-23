using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI fishText;
    public TextMeshProUGUI killText;

    public static Win instance;

    private void Awake()
    {
        instance = this;   
    }
    public void UpdateStats()
    {
        int fishes = FishSystem.instance.fishes;
        fishText.text = fishes.ToString();
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
