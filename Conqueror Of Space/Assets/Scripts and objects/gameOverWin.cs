using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverWin : MonoBehaviour
{
    public float timeDeth = 2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeDeth -= Time.deltaTime;
        if (timeDeth <= 0)
        {
            Time.timeScale = 0f;

        }
    }
}
