using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poocod
{
    public bool vida { get; set;}
    
   
    public Poocod(bool vida)
    {
        this.vida = vida;         
    }

    public bool tocar(bool dano)
    {
        vida = dano;
        dano = true;
        vida = true;
        return vida;
    }

}