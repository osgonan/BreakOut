using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        reistencia = 5;        
    }

    public override void RebotarBola() {
        base.RebotarBola();

    }
}
