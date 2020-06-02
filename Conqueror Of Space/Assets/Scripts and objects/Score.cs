using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreCount;
    public Text score;
    public Text player;

    // Start is called before the first frame update
    void Start()
    {
        player.text = PlayerPrefs.GetString("PlayerName");
        ScoreCount = PlayerPrefs.GetInt("PlayerScore");
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Convert.ToString(ScoreCount);
    }
}
