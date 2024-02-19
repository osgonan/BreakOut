using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MuestraEventos : MonoBehaviour
{

    public UnityEvent eventoUnity;
    public event EventHandler enCasoDelEspacioPresionado;


    // Start is called before the first frame update
    void Start()
    {
        enCasoDelEspacioPresionado += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            enCasoDelEspacioPresionado?.Invoke(this,EventArgs.Empty);
            
        }   
    }
   
    public void EventoEscuchado(object render, EventArgs e) {
        Debug.Log("El evento se escucho correctamente");
        eventoUnity.Invoke();
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("Evento unity Disparaado");
    }
}
