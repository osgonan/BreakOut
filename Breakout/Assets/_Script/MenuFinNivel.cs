using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinNivel : MonoBehaviour
{

    public void SiguienteNivel()
    {
        var siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > siguienteNivel)
        {
            SceneManager.LoadScene(siguienteNivel);
        }
        else
        {
            cargarMenuPrincipal();
        }
    }

    public void cargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);

    }

    public void reintentarNivel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
