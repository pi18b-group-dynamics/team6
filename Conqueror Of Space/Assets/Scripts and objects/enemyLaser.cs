using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLaser : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 100;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.back * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
