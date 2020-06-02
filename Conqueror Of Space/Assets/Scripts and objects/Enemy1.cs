using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Ship;
    public GameObject Laser;
    public GameObject Player;

    public Transform Gun;

    public GameObject shipExplosion;
    public GameObject explotion;

    public AudioSource laserSound;

    float speed;  // Скорость полёта
    public float tilt = 2;    // Наклон

    float shotDeley;
    float nextShot = 0;

    float maxX = 55, minX = -55;

    void Start()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 0)
        {
            speed = 0.5f;
            shotDeley = 2f;
        }
        else { speed = 2f; shotDeley = 1.2f; }
        Player = GameObject.Find("Player");
        Ship = GetComponent<Rigidbody>();
    }


    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "boostFire":
                Destroy(other.gameObject);
                break; ;
            case "boostLive":
                Destroy(other.gameObject);
                break;
            case "boostIntangible":
                Destroy(other.gameObject);
                break;
            case "boostShield":
                Destroy(other.gameObject);
                break;
            case "Asteroid":
                break;
            case "Enemy":
                break;
            case "EnemyLaser":
                break;
            case "Laser":
                Destroy(gameObject);
                Destroy(other.gameObject);
                Player.GetComponent<Score>().ScoreCount += 100;
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                Instantiate(explotion, transform.position, Quaternion.identity);
                break;
            case "Player":
                Destroy(gameObject);
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                Instantiate(explotion, transform.position, Quaternion.identity);
                break;
        }
    }

    void Update()
    {
        Ship.velocity = Vector3.back * speed * 15;
        Ship.rotation = Quaternion.Euler(Ship.velocity.z * tilt / 50, 0, -Ship.velocity.x * tilt / 50);

        attack();
    }

    void attack()
    {
        if (Time.time > nextShot)
        {
            Instantiate(Laser, Gun.position, Quaternion.identity);
            nextShot = Time.time + shotDeley;
            laserSound.Play();
        }
    }
}

