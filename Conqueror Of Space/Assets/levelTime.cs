using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelTime : MonoBehaviour
{

    public Image levTime;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime * 0.05f;
            levTime.fillAmount = time;
        }
        else { levTime.fillAmount = 0; }
    }
}
