using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;
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
        if (HealthSystem.instance.health < 0.1)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Reset()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

}
