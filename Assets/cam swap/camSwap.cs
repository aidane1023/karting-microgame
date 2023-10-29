using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camSwap : MonoBehaviour
{   
    public GameObject cam1;
    public GameObject cam2;

    void Start() 
    {
        cam1.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("1key"))
        {
            cam1.SetActive(true);
        }
        if (Input.GetButtonDown("2key"))
        {
            cam2.SetActive(true);
        }
    }
    
}
