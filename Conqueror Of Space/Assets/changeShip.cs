using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeShip : MonoBehaviour
{
    public void first()
    {
        PlayerPrefs.SetInt("PlayerShip", 1);
    }
    public void second()
    {
        PlayerPrefs.SetInt("PlayerShip", 2);
    }
    public void third()
    {
        PlayerPrefs.SetInt("PlayerShip", 3);
    }
}
