using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLaser : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100;
   
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.forward*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
