using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject laser;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void OnCollitionEnter(Collision variable)
    {
        if (variable.gameObject == Player)
        {
            Player.GetComponent<Score>().ScoreCount += 10;
            Debug.Log("Score");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
