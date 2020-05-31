using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDown : MonoBehaviour
{

    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = Vector3.back * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
