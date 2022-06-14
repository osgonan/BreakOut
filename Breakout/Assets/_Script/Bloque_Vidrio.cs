using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Vidrio : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        reistencia = 2;        
    }

    public override void RebotarBola() {
        if (reistencia <= 0) {
            base.RebotarBola();

        }

    }
}
