using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComportamientoBotonInicio : MonoBehaviour
{

    public void StartGame()
    {
        
        SceneManager.LoadScene(1);
    }


    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("CERRANDO JUEGO");
    }
}
