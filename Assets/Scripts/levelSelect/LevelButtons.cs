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
        SceneManager.LoadScene("IntroLevel1");
        //print("Boton Play Presionado!!!");
    }

    public void play2()
    {
        SceneManager.LoadScene("LevelTwo");
        //print("Boton Play Presionado!!!");
    }

    public void play3()
    {
        SceneManager.LoadScene("LevelThree");
        //print("Boton Play Presionado!!!");
    }
}
