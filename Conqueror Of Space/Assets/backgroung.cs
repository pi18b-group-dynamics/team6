using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroung : MonoBehaviour
{
    public GameObject bac1;
    public GameObject bac2;
    public GameObject bac3;
    public GameObject bac4;
    public GameObject bac5;
    public GameObject bac6;
    void Start()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "level1":
            case "level1hard":
                bac1.SetActive(true);
                break;
            case "level2":
            case "level2hard":
                bac2.SetActive(true);
                break;
            case "level3":
            case "level3hard":
                bac3.SetActive(true);
                break;
            case "level4":
            case "level4hard":
                bac4.SetActive(true);
                break;
            case "level5":
            case "level5hard":
                bac5.SetActive(true);
                break;
            case "level6":
            case "level6hard":
                bac6.SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
