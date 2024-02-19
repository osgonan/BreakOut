using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuOpciones;



    public void mostrarMenuPausa() {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy){
            menuOpciones.SetActive(false);
        }
    }

    public void ocultarMenuPausa() {
        menuPausa.SetActive(false);
    }

    public void mostrarOpciones()
    {

        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);

    }

    public void regresarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
}
