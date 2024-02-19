using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Opciones;

public class DropDownDificultad : MonoBehaviour
{
    public Opciones opciones;

    private TMP_Dropdown dificultad;
    // Start is called before the first frame update
    void Start()
    {


        dificultad = GetComponent<TMP_Dropdown>();
        dificultad.onValueChanged.AddListener(delegate { opciones.cambiarDificultad(dificultad.value); });
    } 
            // Update is called once per frame
    void Update()
    {
        
    }
}
