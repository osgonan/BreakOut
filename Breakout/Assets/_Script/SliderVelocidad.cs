using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVelocidad : MonoBehaviour
{

    public Opciones opciones;

    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { controlarCambios(); });
    }

    void controlarCambios() {

        opciones.cambiarVelocidad(slider.value);
    }
}
