using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SeleccionMundo");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Login()
    {
        SceneManager.LoadScene("Login");
    }
}
