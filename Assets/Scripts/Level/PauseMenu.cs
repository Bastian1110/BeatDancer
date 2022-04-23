using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public bool inPause = false;

    public void Pause()
    {
        inPause = !inPause;
        pausePanel.SetActive(inPause);
        Time.timeScale = inPause ? 0 : 1;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }

}
