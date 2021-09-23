using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interação : MonoBehaviour
{
    public GameObject capsula;
    public Vector3 positionChange;

    Poocod ini = new Poocod(false);
    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag =="Player")
        {
            ini.tocar(true);
            if (ini.vida == true)
            {
                transform.position += positionChange;
            }
        }

    }
}

