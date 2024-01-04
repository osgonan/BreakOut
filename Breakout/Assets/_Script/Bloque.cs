using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int reistencia = 1;
    public bool RebotaEnDestroy = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reistencia <= 0) {
            Destroy(this.gameObject);
        }
    }

    public virtual void RebotarBola() { 
    
    
    }
}
