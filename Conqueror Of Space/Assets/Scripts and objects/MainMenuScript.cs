using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject options;
    public GameObject records;
    public GameObject levelMenu;
    public GameObject shipСhange;
    public GameObject confirmExitToDesctop;
    public GameObject confirmExitToMenu;
    public GameObject playerName;
    public GameObject autor;
    public GameObject help;

    public void Start()
    {
    }

    public void Update()
    {
            
    }

    public void toMainMenuScene()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }

    // универсальная кнопка для выхода в главное меню
    public void toMainMenu()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
        options.SetActive(false);
        records.SetActive(false);
        playerName.SetActive(false);
        confirmExitToDesctop.SetActive(false);
        confirmExitToMenu.SetActive(false);

    }

    // кнопки главного меню
    // меню уровней
    public void toLevelMenu ()
    {
            mainMenu.SetActive(false);
            playerName.SetActive(true);
            levelMenu.SetActive(true);
    }
    // меню настроек
    public void toOptions()
    {
        options.SetActive(true);
        shipСhange.SetActive(false);
        help.SetActive(false);
        autor.SetActive(false);
        mainMenu.SetActive(false);
    }
    // таблица рекордов
    public void toRecords()
    {
            mainMenu.SetActive(false);
            records.SetActive(true);
    }
    // окно подверждения
    public void toExit()
    {
        confirmExitToDesctop.SetActive(true);
    }
    // выход из игры
    public void Exit()
    {
            Application.Quit();
    }

    // кнопки меню уровней
    // уровень 1
    public void lelel1()
    {
        if(PlayerPrefs.GetInt("Difficulty") == 0)
          SceneManager.LoadScene("level1", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level1hard", LoadSceneMode.Single);

    }
    // уровень 2
    public void lelel2()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
            SceneManager.LoadScene("level2", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level2hard", LoadSceneMode.Single);
    }
    // уровень 3
    public void lelel3()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
            SceneManager.LoadScene("level3", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level3hard", LoadSceneMode.Single);
    }
    // уровень 4
    public void lelel4()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
            SceneManager.LoadScene("level4", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level4hard", LoadSceneMode.Single);
    }
    // уровень 5
    public void lelel5()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
            SceneManager.LoadScene("level5", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level5hard", LoadSceneMode.Single);
    }
    // уровень 6
    public void lelel6()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
            SceneManager.LoadScene("level6", LoadSceneMode.Single);
        else
            SceneManager.LoadScene("level6hard", LoadSceneMode.Single);
    }

    // кнопки меню настроек
    public void toChangeShip()
    {
        shipСhange.SetActive(true);
        options.SetActive(false);
    }

    public void toAutor()
    {
        autor.SetActive(true);
        options.SetActive(false);
    }

    public void toHelp()
    {
        help.SetActive(true);
        options.SetActive(false);
    }

    public void toExitFromeGameToMain()
    {
        confirmExitToMenu.SetActive(true);
    }

    public void toExitFromeGameToDesctop()
    {
        confirmExitToDesctop.SetActive(true);
    }

    public void backToOptions()
    {
            autor.SetActive(false);
            shipСhange.SetActive(false);
            help.SetActive(false);
            options.SetActive(true);
    }
}
