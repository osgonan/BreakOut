using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu (fileName ="Opciones",menuName ="Herramientas/Opciones",order =1)]
public class Opciones : ObjetoPersistente
{
    public float velocidadBola = 30;
    public dificultad nivelDificultad = dificultad.facil;
    public enum dificultad { 
        facil,normal,dificil
    
    }

    public void cambiarVelocidad(float nuevaVelocidad) { 
        velocidadBola = nuevaVelocidad;
    }

    public void cambiarDificultad(int nuevaDificultad) {
        Debug.Log(nuevaDificultad);

        nivelDificultad = (dificultad)nuevaDificultad;
    }

}
