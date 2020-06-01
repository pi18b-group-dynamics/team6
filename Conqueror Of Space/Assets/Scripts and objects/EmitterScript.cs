using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterScript : MonoBehaviour
{
    public GameObject asteroid;

    public GameObject boostShield;
    public GameObject boostLive;
    public GameObject boostFire;
    public GameObject boostInvisible;

    public GameObject Enemy1;
    public GameObject Enemy2;

    public GameObject PlayerShip;
    public GameObject Boss;

    public float minDelay, maxDelay;
    public float timeSpawn;
    public float minEnemyDelay1, maxEnemyDelay1;
    public float minEnemyDelay2, maxEnemyDelay2;
    public float minBoostDelay = 1f, maxBoostDelay = 5f;
    float nextLaunch;
    float nextLaunchBoost;
    float nextLaunchEnemy1;
    float nextLaunchEnemy2;


    // Start is called before the first frame update
    void Start()
    {
    }

    private void bossInit()
    {
        if (timeSpawn > 0)
        {
            timeSpawn -= Time.deltaTime;
        }
        else
        {
            Boss.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        bossInit();
        float size = transform.localScale.x;
        // запуск астеройдов
        if (Time.time > nextLaunch)
        {
            float xPos = Random.Range(-size / 2-10, size / 2-10);
            Vector3 asteroidPosition = new Vector3(xPos, 0, transform.position.z);
            GameObject newAsteroid =  Instantiate(asteroid, asteroidPosition, Quaternion.identity);
            float resize = Random.Range(0.5f, 1);
            newAsteroid.transform.localScale *= resize;

            nextLaunch = Time.time + Random.Range(minDelay, maxDelay);
        }
        // запуск бустов
        if (Time.time > nextLaunchBoost)
        {
            float xPos = Random.Range(-size / 2, size / 2);
            int boostType = Random.Range(1, 10);
            switch (boostType)
            {
                case 1:
                    Vector3 boostShieldPosition = new Vector3(xPos, 0, transform.position.z);
                    Instantiate(boostShield, boostShieldPosition, Quaternion.identity);
                    break;
                case 2:
                    Vector3 boostLivePosition = new Vector3(xPos, 0, transform.position.z);
                    Instantiate(boostLive, boostLivePosition, Quaternion.identity);
                    break;
                case 3:
                    Vector3 boostFirePosition = new Vector3(xPos, 0, transform.position.z);
                    Instantiate(boostFire, boostFirePosition, Quaternion.identity);
                    break;
                case 4:
                    Vector3 boostInvisPosition = new Vector3(xPos, 0, transform.position.z);
                    Instantiate(boostInvisible, boostInvisPosition, Quaternion.identity);
                    break;
            }
            
            nextLaunchBoost = Time.time + Random.Range(minBoostDelay, maxBoostDelay);
        }
        // запуск штурмовика
        if (Time.time > nextLaunchEnemy1)
        {
            float xPos = Random.Range(-size / 2, size / 2);
            Vector3 enemy1 = new Vector3(xPos, 0, transform.position.z);
            Instantiate(Enemy1, enemy1, Quaternion.identity);
            nextLaunchEnemy1 = Time.time + 15;
        }
        if (Time.time > nextLaunchEnemy2)
        {
            float xPos = Random.Range(-size / 2, size / 2);
            Vector3 enemy2 = new Vector3(xPos, 0, transform.position.z);
            Instantiate(Enemy2, enemy2, Quaternion.identity);
            nextLaunchEnemy2 = Time.time + 15;
        }
    }
}
