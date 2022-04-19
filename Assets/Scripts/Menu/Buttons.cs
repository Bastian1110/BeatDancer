using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("LevelTest");
        //print("Boton Play Presionado!!!");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
        //print("Boton Play Presionado!!!");
    }
}
