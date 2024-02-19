using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Lodo : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        if ((int)opciones.nivelDificultad == 2)
        {
            resistencia = 2 * (int)opciones.nivelDificultad;
        }
        else
        {
            resistencia = 2;
        }
    }

    public override void RebotarBola() {
        base.RebotarBola();

    }
}
