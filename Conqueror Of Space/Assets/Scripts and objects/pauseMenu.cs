using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool Paused = false;

    public GameObject pauseMenuGUI;
    public GameObject confirm1;
    public GameObject confirm2;
    public GameObject options;

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
        GetComponent<MainMenuScript>().confirmExitToMenu.SetActive(false);
        GetComponent<MainMenuScript>().confirmExitToDesctop.SetActive(false);
        GetComponent<MainMenuScript>().options.SetActive(false);
        GetComponent<MainMenuScript>().autor.SetActive(false);
        GetComponent<MainMenuScript>().help.SetActive(false);

        pauseMenuGUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Paused = false;
    }

    public void toPause()
    {
        pauseMenuGUI.SetActive(true);
        options.SetActive(false);
        confirm1.SetActive(false);
        confirm2.SetActive(false);
    }

    private void Pause()
    {
        pauseMenuGUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Paused = true;
    }
}
