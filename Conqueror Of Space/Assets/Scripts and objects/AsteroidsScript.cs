using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsScript : MonoBehaviour
{
    public float minRotationSpeed, maxRotationSpeed;
    float minMoveSpeed, maxMoveSpeed;
    public GameObject asteroidExplosion;
    public GameObject smallAsteroidExplosion;
    public GameObject explotion;
    public GameObject enemyShip;
    public GameObject Player;
    int lives;

    int score;

    void Start()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
        {
            minMoveSpeed = 5; maxMoveSpeed = 15;
        }
        else { minMoveSpeed = 8; maxMoveSpeed = 20; }
        Player = GameObject.Find("Player");
        Rigidbody asteroid = GetComponent<Rigidbody>();
        asteroid.angularVelocity = Random.insideUnitSphere * Random.Range(minRotationSpeed, maxRotationSpeed);
        asteroid.velocity = Vector3.back * Random.Range(minMoveSpeed, maxMoveSpeed);
        if (asteroid.transform.localScale.x <= 0.4f) 
        { lives = 1; score = 10; }
        else if (asteroid.transform.localScale.x <= 0.8f && asteroid.transform.localScale.x > 0.4f) 
        { lives = 2; score = 20; }
        else if (asteroid.transform.localScale.x > 0.8f) 
        {lives = 3; score = 30; }
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "bostFire":
                return;
            case "bostLive":
                return;
            case "bostIntagible":
                return;
            case "bostShield":
                return;
            case "Laser":
                lives--;
                if (lives > 0)
                {  
                    Destroy(other.gameObject);
                    Instantiate(smallAsteroidExplosion, transform.position, Quaternion.identity);
                    Instantiate(explotion, transform.position, Quaternion.identity);
                }
                if (lives <= 0)
                {
                    Instantiate(asteroidExplosion, transform.position, Quaternion.identity);
                    Instantiate(explotion, transform.position, Quaternion.identity);
                    Player.GetComponent<Score>().ScoreCount += score;
                    Destroy(other.gameObject);
                    Destroy(gameObject);
                }
                break;
            case "Boundary":
                return;
        }

    }
    
    void Update()
    {
        
    }
}
