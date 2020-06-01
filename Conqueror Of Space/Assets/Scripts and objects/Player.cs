using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody PlayerShip;
    public Light BlueLight;
    public Light GreenLight;
    public GameObject Laser;
    public GameObject LaserLeft;
    public GameObject LaserRight;

    public GameObject gameOver;
    public GameObject Emiter;
    public GameObject boss;

    public float timeDeth = 2;

    public Text liveCount;
    public Text fireTime;
    public Text shieldTime;
    public Text inviseTime;

    public Transform Gun;

    public GameObject shipExplosion;
    public GameObject smallAsteroidExplosion;
    public GameObject smallShipExplosion;
    public GameObject explotion;

    public AudioSource laserSound;
    public AudioSource boostSound;

    public float timeBoostFire;
    public float timeBoostDefender1;
    public float timeBoostDefender2;
    public bool boostFire, boostShield, boostIntangible;

    public int lives = 3;

    public float speed = 20;  // Скорость полёта
    public float tilt = 4;    // Наклон

    public float shotDeley = 1; 
    float nextShot = 0;

    float maxX = 55, minX = -55, maxZ = -1, minZ = -29;

    void Start()
    {
        PlayerShip = GetComponent<Rigidbody>();
        BlueLight.enabled = false; GreenLight.enabled = false;
        boostFire = false; boostShield = false ; boostIntangible = false;
        timeBoostFire = 0; timeBoostDefender1 = 0; timeBoostDefender2 = 0;
        GetComponent<SphereCollider>().enabled = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "boostFire":
                Destroy(other.gameObject);
                timeBoostFire = 20f;
                boostFire = true;
                boostSound.Play();
                fireTime.text = Convert.ToString(lives);
                break; ;
            case "boostLive":
                Destroy(other.gameObject);
                boostSound.Play();
                lives++;
                liveCount.text = Convert.ToString(lives);
                break;
            case "boostIntangible":
                Destroy(other.gameObject);
                timeBoostDefender1 = 20f;
                boostIntangible = true;
                boostSound.Play();
                inviseTime.text = Convert.ToString(lives);
                break;
            case "boostShield":
                Destroy(other.gameObject);
                timeBoostDefender2 = 20f;
                boostShield = true;
                boostSound.Play();
                shieldTime.text = Convert.ToString(lives);
                break;
            case "Asteroid":
                Instantiate(explotion, transform.position, Quaternion.identity);
                Instantiate(smallAsteroidExplosion, transform.position, Quaternion.identity);
                AsteroidDestroy(other);
                break;
            case "Enemy":
                Instantiate(explotion, transform.position, Quaternion.identity);
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                EnemyDestroy(other);
                break;
            case "EnemyLaser":
                Instantiate(explotion, transform.position, Quaternion.identity);
                LaserDestroy(other);
                break;
            case "Boss":
                BossDestroy(other);
                return;
        }
    }

    private void EnemyDestroy(Collider other)
    {
        if (boostShield == true) { Destroy(other.gameObject); GetComponent<Score>().ScoreCount += 10; }
        else if (boostIntangible == true) { }
        else
        {
            lives--;
            liveCount.text = Convert.ToString(lives);
            if (lives == 0)
            {
                Instantiate(gameOver, transform.position, Quaternion.identity);
                Destroy(gameObject);
                gameOver.SetActive(true);
            }
        }
    }

    private void BossDestroy(Collider other)
    {
        if (boostShield == true) { GetComponent<Score>().ScoreCount += 10; }
        else if (boostIntangible == true) { }
        else
        {
            lives--;
            liveCount.text = Convert.ToString(lives);
            if (lives == 0)
            {
                Instantiate(gameOver, transform.position, Quaternion.identity);
                Destroy(gameObject);
                gameOver.SetActive(true);

            }
        }
    }

    private void AsteroidDestroy(Collider other)
    {
        if (boostShield == true) { Destroy(other.gameObject); GetComponent<Score>().ScoreCount += 10; }
        else if (boostIntangible == true) { }
        else
        {
            lives--;
            liveCount.text = Convert.ToString(lives);
            if (lives > 0)
            {
                GetComponent<Score>().ScoreCount += 10;
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                Destroy(other.gameObject);

            }
            if (lives <= 0)
            {
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                Instantiate(gameOver, transform.position, Quaternion.identity);
                Destroy(other.gameObject);
                Destroy(gameObject);
                gameOver.SetActive(true);

            }
        }
    }

    private void LaserDestroy(Collider other)
    {
        if (boostShield == true) { Destroy(other.gameObject); }
        else if (boostIntangible == true) { }
        else
        {
            lives--;
            Destroy(other.gameObject);
            Instantiate(smallAsteroidExplosion, transform.position, Quaternion.identity);
            if (lives == 0 || lives < 0)
            {
                Instantiate(gameOver, transform.position, Quaternion.identity);
                Instantiate(shipExplosion, transform.position, Quaternion.identity);
                Destroy(gameObject);
                Destroy(other.gameObject);
                gameOver.SetActive(true);

            }
        }
    }

    void gameOverMenu()
    {

    }

    void tribleFire(float timeBoost)
    {
        Instantiate(Laser, Gun.position, Quaternion.identity);
        Instantiate(LaserLeft, Gun.position, Quaternion.identity);
        Instantiate(LaserRight, Gun.position, Quaternion.identity);
        nextShot = Time.time + shotDeley;
        laserSound.Play();
        if (timeBoostFire <= 0) {
            boostFire = false;
            timeBoostFire = 0;
            fireTime.text = Convert.ToString(timeBoostFire);
        }
    }

    void activateShild(float timeBoostDefender2)
    {
        GreenLight.enabled = true;
        if (timeBoostDefender2 <= 0)
        {
            boostShield = false;
            GreenLight.enabled = false;
            timeBoostDefender2 = 0;
            shieldTime.text = Convert.ToString(timeBoostDefender2);
        }
    }

    void activateIntengible(float timeBoostDefender1)
    {
        GetComponent<BoxCollider>().enabled = false;
        BlueLight.enabled = true;
        if (timeBoostDefender1 <= 0)
        {
            boostIntangible = false;
            BlueLight.enabled = false;
            GetComponent<BoxCollider>().enabled = true;
            timeBoostDefender1 = 0;
            inviseTime.text = Convert.ToString(timeBoostDefender1);
        }
    }

    void Update()
    {
        liveCount.text = Convert.ToString(lives);
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        PlayerShip.velocity = new Vector3(moveHorizontal, 0, moveVertical) * speed * 15;

        PlayerShip.rotation = Quaternion.Euler(PlayerShip.velocity.z * tilt / 50, 0, -PlayerShip.velocity.x * tilt / 50);

        // макс и мин позиции
        float newXPosition = Mathf.Clamp(PlayerShip.position.x, minX, maxX);
        float newZPosition = Mathf.Clamp(PlayerShip.position.z, minZ, maxZ);

        PlayerShip.position = new Vector3(newXPosition, 0, newZPosition);
        
        boostFireWork();
        boostShieldWork();
        boostIntengibledWork();
    }

    private void boostFireWork()
    {
        if (boostFire = true && timeBoostFire > 0)
        {
            timeBoostFire -= Time.deltaTime;
            fireTime.text = Convert.ToString(Math.Round(timeBoostFire));
        }
        attack();
    }

    private void boostShieldWork()
    {
        if (boostShield = true && timeBoostDefender2 > 0)
        {
            timeBoostDefender2 -= Time.deltaTime;
            shieldTime.text = Convert.ToString(Math.Round(timeBoostDefender2));
        }
        activateShild(timeBoostDefender2);
    }

    private void boostIntengibledWork()
    {
        if (boostIntangible = true && timeBoostDefender1 > 0)
        {
            timeBoostDefender1 -= Time.deltaTime;
            inviseTime.text = Convert.ToString(Math.Round(timeBoostDefender1));
        }
        activateIntengible(timeBoostDefender1);
    }

    void attack()
    {
        if (Time.time > nextShot && Input.GetButton("Fire1"))
        {
            if (boostFire = true && timeBoostFire > 0) tribleFire(timeBoostFire);
            else
            {
                Instantiate(Laser, Gun.position, Quaternion.identity);
                nextShot = Time.time + shotDeley;
                laserSound.Play();
            }
        }
    }

}
