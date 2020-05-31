using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLaser : MonoBehaviour
{
    void Update()
    {
        //gameObject.transform.Rotate(0, 100 * Time.deltaTime, 0);
        //gameObject.transform.rotation.y = -35;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, -35, 0));
        GetComponent<Rigidbody>().velocity = new Vector3(-35, 0, 35);
    }
}
