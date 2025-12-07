using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prueba : MonoBehaviour
{
    public GameObject miCarta;
    public int miNumero;
    public string miString;
    public bool miBool;




    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            miCarta.GetComponent<Image>().color = Color.red;
        }
       
    }
}
