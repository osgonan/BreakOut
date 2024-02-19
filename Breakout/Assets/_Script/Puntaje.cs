using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoPuntajeActual;

    public PuntajeAlto puntajeAlto;
    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeAlto = GameObject.Find("Puntaje Alto").transform;
        transformPuntajeActual = GameObject.Find("Puntaje Actual").transform;
        textoPuntajeActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();

        puntajeAlto.Cargar();
        textoPuntajeAlto.text = $"Puntaje Alto: {puntajeAlto.puntajeAlto}";
        puntajeAlto.puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntajeActual.text = $"Puntaje Actual:{puntajeAlto.puntaje} ";
        if (puntajeAlto.puntaje > puntajeAlto.puntajeAlto) {

            puntajeAlto.puntajeAlto = puntajeAlto.puntaje;
            puntajeAlto.Guardar();
            textoPuntajeAlto.text = $"Puntaje Alto: {puntajeAlto.puntajeAlto}";
        }
    }

    public void aumentarPuntaje(int puntos) {
        puntajeAlto.puntaje += puntos;
    }
}
