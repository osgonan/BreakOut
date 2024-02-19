using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject menuOpciones;
    public GameObject menuInicial;

    public void iniciarJuego() {

        SceneManager.LoadScene(1);
    }

    public void finalizarJuego()
    {
        Application.Quit();

    }

    public void mostrarOpciones() { 
    
        menuInicial.SetActive(false);
        menuOpciones.SetActive(true);

    }

    public void mostrarMenuInicial() {
        menuOpciones.SetActive(false);
        menuInicial.SetActive(true);
    }

}
