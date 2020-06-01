using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerNameScript : MonoBehaviour
{

    public InputField input;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        input.text = PlayerPrefs.GetString("PlayerName");
    }

    public void setName()
    {
        if (input.text != null || !input.text.Equals(" "))
        {
            PlayerPrefs.SetString("PlayerName", input.text);
            gameObject.SetActive(false);
        }
        else input.text = "Ведите ваш никнейм!"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
