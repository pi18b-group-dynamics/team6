using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    public Text score;
    public Text header;
    public Text player;

    public Text playerScore;

    public GameObject confirm;
    public GameObject final;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        player.text = PlayerPrefs.GetString("PlayerName");
        PlayerPrefs.SetInt("PlayerScoreNew", Convert.ToInt32(playerScore.text));
        score.text = Convert.ToString(PlayerPrefs.GetInt("PlayerScoreNew"));
    }

    public void confirmExitToMenyFromEndGame()
    {
        confirm.SetActive(true);
    }

    public void stay()
    {
        confirm.SetActive(false);
    }

    public void level2()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level2", LoadSceneMode.Single);
    }

    public void level3()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level3", LoadSceneMode.Single);
    }
    public void level4()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level4", LoadSceneMode.Single);
    }
    public void level5()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level5", LoadSceneMode.Single);
    }
    public void level6()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level6", LoadSceneMode.Single);
    }

    public void level2hard()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level2hard", LoadSceneMode.Single);
    }

    public void level3hard()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level3hard", LoadSceneMode.Single);
    }
    public void level4hard()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level4hard", LoadSceneMode.Single);
    }
    public void level5hard()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level5hard", LoadSceneMode.Single);
    }
    public void level6hard()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("level6hard", LoadSceneMode.Single);
    }

    public void ToMenyFromEndGame()
    {
        PlayerPrefs.SetInt("PlayerScore", PlayerPrefs.GetInt("PlayerScoreNew"));
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }

    public void returnLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void win()
    {
        final.SetActive(true);
    }
}
