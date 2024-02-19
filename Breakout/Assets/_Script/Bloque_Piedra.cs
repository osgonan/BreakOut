using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        if ((int)opciones.nivelDificultad == 2)
        {
            resistencia = 5 * (int)opciones.nivelDificultad;

        }
        else
        {
            resistencia = 0;
        }
    }

    public override void RebotarBola() {
        base.RebotarBola();

    }
}
