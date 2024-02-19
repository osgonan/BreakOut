using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia;
    public bool RebotaEnCollision = true;

    public UnityEvent aumentarPuntaje;
    public Opciones opciones;

    // Start is called before the first frame update
    void Start()
    {
        if ((int)opciones.nivelDificultad == 2)
        {
            resistencia = (int)opciones.nivelDificultad;

        }
        else {
            resistencia = 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bola")) {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        if (RebotaEnCollision) {
            Vector3 direcccion = collision.contacts[0].point - transform.position;
            direcccion = direcccion.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direcccion;
            
        }
        resistencia--;

    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0) {
            Destroy(this.gameObject);
            aumentarPuntaje.Invoke();
        }
    }

    public virtual void RebotarBola() { 
    
    
    }

 
}
