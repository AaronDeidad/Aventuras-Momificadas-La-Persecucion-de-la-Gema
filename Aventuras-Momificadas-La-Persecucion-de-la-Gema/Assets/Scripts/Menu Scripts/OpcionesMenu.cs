using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{
    public void MoverNivel(string NombreNivel)
    {
        SceneManager.LoadScene(NombreNivel);
    }    
  public void salir()
    {
     Application.Quit();
        Debug.Log("cerro");
    }

}
