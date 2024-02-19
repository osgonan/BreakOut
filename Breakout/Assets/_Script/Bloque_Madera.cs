using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        if ((int)opciones.nivelDificultad == 2)
        {
            resistencia = 3 * (int)opciones.nivelDificultad;
        }
        else {
            resistencia = 3;
        }
        RebotaEnCollision=true;
    }


}
