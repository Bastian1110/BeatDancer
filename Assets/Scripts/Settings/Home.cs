using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void Casa()
    {
        SceneManager.LoadScene("Menu");
    }
     public void intruction()
    {
        SceneManager.LoadScene("Instructions");
    }
}
