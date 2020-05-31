using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1 : MonoBehaviour
{
    Rigidbody BossShip;
    public Transform Gun1;
    public Transform Gun2;
    public Transform Player;
    public GameObject player;

    public AudioSource laserSound;

    public GameObject explotion;
    public GameObject shipExplosion;
    public GameObject finalExplotion;
    public GameObject Laser;

    public int lives;
    public int startlives;

    public float shotDeley = 1;
    float nextShot = 0;

    float maxX = 55, minX = -55, maxZ = 70, minZ = 18;

    void Start()
    {
        player = GameObject.Find("Player");
        BossShip = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
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
                GetComponent<healthBar>().fill -= 1f/startlives;
                if (lives > 0)
                {
                    Destroy(other.gameObject);
                    Instantiate(shipExplosion, other.gameObject.transform.position, Quaternion.identity);
                    Instantiate(explotion, transform.position, Quaternion.identity);
                    player.GetComponent<Score>().ScoreCount += 10;
                }
                if (lives <= 0)
                {
                    Instantiate(finalExplotion, transform.position, Quaternion.identity);
                    Instantiate(explotion, transform.position, Quaternion.identity);
                    player.GetComponent<Score>().ScoreCount += 1000;
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
            attack();

            BossShip.position = Vector3.MoveTowards(BossShip.transform.position, Player.position, Time.deltaTime*30);

            float newXPosition = Mathf.Clamp(BossShip.position.x, minX, maxX);
            float newZPosition = Mathf.Clamp(BossShip.position.z, minZ, maxZ);
            
            BossShip.position = new Vector3(newXPosition, 0, newZPosition);
    }


    void attack()
    {
        if (Time.time > nextShot)
        {
            Instantiate(Laser, Gun1.position, Quaternion.identity);
            Instantiate(Laser, Gun2.position, Quaternion.identity);
            nextShot = Time.time + shotDeley;
            laserSound.Play();
        }
    }
}
