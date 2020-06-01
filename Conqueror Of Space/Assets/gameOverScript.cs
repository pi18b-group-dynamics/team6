using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    public Text score;
    public Text header;
    public Text player;

    public Text playerScore;

    // Start is called before the first frame update
    void Start()
    {
        player.text = PlayerPrefs.GetString("PlayerName");
        PlayerPrefs.SetInt("PlayerScore", Convert.ToInt32(playerScore.text));
        PlayerPrefs.SetInt("PlayerScoreNew", Convert.ToInt32(playerScore.text));
        score.text = Convert.ToString(PlayerPrefs.GetInt("PlayerScoreNew"));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
