using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBordes : MonoBehaviour
{

    [Header("Configurar en el editor")]
    public float radio = 1f;
    public bool mantenerEnPantalla = false;

    [Header("Configuraciones Dinamicas")]
    public bool estaEnPantalla=true;
    public float anchoCamara;
    public float altoCamara;
    public bool salioDerecha, salioIzquierda, salioArriba, salioAbajo;


    public void Awake()
    {
        altoCamara = Camera.main.orthographicSize;
        anchoCamara = Camera.main.aspect*altoCamara;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        estaEnPantalla = true;
        salioAbajo = salioArriba = salioDerecha = salioDerecha = false;
        if (pos.x > anchoCamara - radio) {
            pos.x = anchoCamara - radio;
            salioDerecha = true;
        }
        if (pos.x < -anchoCamara + radio)
        {
            pos.x = -anchoCamara - radio;
            salioIzquierda = true;
        }

        if (pos.y > altoCamara - radio) {

            pos.y = altoCamara - radio;
            salioArriba = true;
        }
        if (pos.y < -altoCamara + radio) {
            pos.y = -altoCamara + radio;
            salioAbajo = true;
        }

        estaEnPantalla = !(salioAbajo || salioArriba || salioDerecha || salioIzquierda);

        if (mantenerEnPantalla && !estaEnPantalla) {
            transform.position = pos;
            estaEnPantalla = true;
        }
    }

    private void OnDrawGizmos()
    {
        if(!Application.isPlaying)
        {
            return;
        }
        Vector3 tamanioBorde = new Vector3(anchoCamara*2, altoCamara * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero,tamanioBorde);
    }
}
