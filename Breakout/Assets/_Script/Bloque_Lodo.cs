using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Lodo : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        reistencia = 4;        
    }

    public override void RebotarBola() {
        base.RebotarBola();

    }
}
