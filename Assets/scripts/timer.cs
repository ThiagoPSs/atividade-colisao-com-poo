using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public GameObject TextoTempo;
    public static double tempo;
    bool fim;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q)){

            fim = false;

        }
        if(Input.GetKey(KeyCode.E))
        {
            fim = true;
        }
        if(fim == false)
        {
            tempo += 0.001;
            TextoTempo.GetComponent<Text>().text = "Timer:" + tempo;
        }

    }



}
