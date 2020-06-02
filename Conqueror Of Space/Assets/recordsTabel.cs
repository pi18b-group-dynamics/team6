using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordsTabel : MonoBehaviour
{
    // Start is called before the first frame update
    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
    public Text player5;
    public Text player6;
    public Text player7;
    public Text player8;
    public Text player9;
    public Text player10;

    public Text scores1;
    public Text scores2;
    public Text scores3;
    public Text scores4;
    public Text scores5;
    public Text scores6;
    public Text scores7;
    public Text scores8;
    public Text scores9;
    public Text scores10;
    string[] players = new string[11];
    int[] scores = new int[11];

    void readFromText()
    {
        players[0] = player1.text;
        players[1] = player2.text;
        players[2] = player3.text;
        players[3] = player4.text;
        players[4] = player5.text;
        players[5] = player6.text;
        players[6] = player7.text;
        players[7] = player8.text;
        players[8] = player9.text;
        players[9] = player10.text;

        scores[0] = Convert.ToInt32(scores1.text);
        scores[1] = Convert.ToInt32(scores2.text);
        scores[2] = Convert.ToInt32(scores3.text);
        scores[3] = Convert.ToInt32(scores4.text);
        scores[4] = Convert.ToInt32(scores5.text);
        scores[5] = Convert.ToInt32(scores6.text);
        scores[6] = Convert.ToInt32(scores7.text);
        scores[7] = Convert.ToInt32(scores8.text);
        scores[8] = Convert.ToInt32(scores9.text);
        scores[9] = Convert.ToInt32(scores10.text);
    }


    void Start()
    {
        readFromText();
        for(int i =0; i < 10; i++)
        {
            players[i] = PlayerPrefs.GetString(string.Format("PlayerName{0}", i++));
            scores[i] = PlayerPrefs.GetInt(string.Format("PlayerScore{0}", i++));
        }
        players[10] = PlayerPrefs.GetString("PlayerName");
        scores[10] = PlayerPrefs.GetInt("PlayerScoreNew");
        sortTable();
        fillToText();
    }
    
    void sortTable()
    {
        int temp;
        string tempS;
        for (int i = 0; i < scores.Length; i++)
        {
            for (int j = i + 1; j < scores.Length; j++)
            {
                if (scores[i] < scores[j])
                {
                    temp = scores[i];
                    tempS = players[i];
                    scores[i] = scores[j];
                    players[i] = players[j];
                    scores[j] = temp;
                    players[j] = tempS;
                }
            }
        }
        //for (int i = 0; i < 10; i++)
        //{
        //    PlayerPrefs.SetString(string.Format("PlayerName{0}", i++), players[i]);
        //    PlayerPrefs.SetInt(string.Format("PlayerScore{0}", i++), scores[i]);
        //}
    }

    void fillToText()
    {
        player1.text = players[0];
        player2.text = players[1];
        player3.text = players[2];
        player4.text = players[3];
        player5.text = players[4];
        player6.text = players[5];
        player7.text = players[6];
        player8.text = players[7];
        player9.text = players[8];
        player10.text = players[9];

        scores1.text = Convert.ToString(scores[0]);
        scores2.text = Convert.ToString(scores[1]);
        scores3.text = Convert.ToString(scores[2]);
        scores4.text = Convert.ToString(scores[3]);
        scores5.text = Convert.ToString(scores[4]);
        scores6.text = Convert.ToString(scores[5]);
        scores7.text = Convert.ToString(scores[6]);
        scores8.text = Convert.ToString(scores[7]);
        scores9.text = Convert.ToString(scores[8]);
        scores10.text = Convert.ToString(scores[9]);
    }
}
