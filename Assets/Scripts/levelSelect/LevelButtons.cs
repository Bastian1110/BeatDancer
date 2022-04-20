using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtons : MonoBehaviour
{
    public void casa()
    {
        SceneManager.LoadScene("Menu");
        //print("Boton Play Presionado!!!");
    }

    public void play1()
    {
        SceneManager.LoadScene("LevelTest");
        //print("Boton Play Presionado!!!");
    }
}
