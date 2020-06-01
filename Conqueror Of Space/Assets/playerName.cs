using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerName : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefs.SetString("PlayerName", "UniverseEvil");
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
