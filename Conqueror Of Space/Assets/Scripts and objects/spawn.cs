using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform spawnShip;
    public GameObject Ship;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Ship, spawnShip.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
