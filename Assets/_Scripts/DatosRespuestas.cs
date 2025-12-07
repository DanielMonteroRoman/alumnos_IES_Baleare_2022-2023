using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosRespuestas : MonoBehaviour
{

    public GameObject panelAcierto;
    public GameObject panelFallo;


    public bool isCorrectAnswer;



    public void ComprobarRespuesta()
    {
        if (isCorrectAnswer)
        {
            panelAcierto.SetActive(true);
        }
        else
        {
            panelFallo.SetActive(true);
        }
    }
}
