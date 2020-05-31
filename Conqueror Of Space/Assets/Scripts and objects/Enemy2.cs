using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Ship;
    public GameObject Laser;
    public GameObject target;

    public Transform Gun;

    public GameObject shipExplosion;
    public GameObject explotion;

    public AudioSource laserSound;

    public float speed = 3;  // Скорость полёта
    public float tilt = 2;    // Наклон

    public float shotDeley = 1;
    float nextShot = 0;

    float maxX = 55, minX = -55, maxZ = 70, minZ = 1;

    void Start()
    {
        target = GameObject.Find("Player");
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
                target.GetComponent<Score>().ScoreCount += 200;
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
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime*20f);
        Ship.rotation = Quaternion.Euler(Ship.velocity.z * tilt / 50, 0, -Ship.velocity.x * tilt / 50);
        attack();

        float newXPosition = Mathf.Clamp(Ship.position.x, minX, maxX);
        float newZPosition = Mathf.Clamp(Ship.position.z, minZ, maxZ);

        Ship.position = new Vector3(newXPosition, 0, newZPosition);
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

