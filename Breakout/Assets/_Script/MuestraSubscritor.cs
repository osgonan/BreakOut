using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSubscritor : MonoBehaviour
{
    MuestraEventos subscritor;
    // Start is called before the first frame update
    void Start()
    {
        subscritor = GetComponent<MuestraEventos>();
        subscritor.enCasoDelEspacioPresionado += MensajeEscuchadoPorSubscritor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MensajeEscuchadoPorSubscritor(object render, EventArgs e) {
        Debug.Log("El evento del subscritor ha sido escuchado desde otra clase");
        subscritor.enCasoDelEspacioPresionado -= MensajeEscuchadoPorSubscritor;

    }
}
