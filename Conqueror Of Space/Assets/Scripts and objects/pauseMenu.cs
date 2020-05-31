using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuGUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            } 
        }
    }

    public void Resume()
    {
        pauseMenuGUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    private void Pause()
    {
        pauseMenuGUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
