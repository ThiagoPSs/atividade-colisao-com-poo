using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformas : MonoBehaviour
{
    float vel { get; set;}
    public Vector3 rotateChange;
    public Vector3 scaleChange;

    public plataformas(float vel) 
    {
        this.vel = vel;
    }
    void Update()
    {

        transform.Rotate(rotateChange);
        
        transform.Rotate(rotateChange * vel);

        transform.localScale += scaleChange;
    }
}