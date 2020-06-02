using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autor : MonoBehaviour
{
    public GameObject options;
    public GameObject autors;
    // Start is called before the first frame update
    public void toOptions()
    {
        options.SetActive(true);
        autors.SetActive(false);
    }
}
