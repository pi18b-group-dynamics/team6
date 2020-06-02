using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class difficulty : MonoBehaviour
{
    public GameObject confirm;
    public Text confirmText;
    // Start is called before the first frame update
    public void setEasy()
    {
        PlayerPrefs.SetInt("Difficulty", 0);
        confirmText.text = "Новичок";
        confirm.SetActive(true);
    }
    public void setHard()
    {
        PlayerPrefs.SetInt("Difficulty", 1);
        confirmText.text = "Бывалый";
        confirm.SetActive(true);
    }

    public void conffirmOff()
    {
        confirm.SetActive(false);
    }
}
