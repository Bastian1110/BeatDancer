using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Exit : MonoBehaviour
{
 public void regresa()
    {
        SceneManager.LoadScene("Settings");
        //print("Boton Play Presionado!!!");
    }   
}
