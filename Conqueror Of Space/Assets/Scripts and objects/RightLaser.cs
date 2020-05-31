using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLaser : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 35, 0));
        GetComponent<Rigidbody>().velocity = new Vector3(35, 0, 35);
    }
}
