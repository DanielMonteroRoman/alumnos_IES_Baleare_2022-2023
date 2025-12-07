using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;
using Random = UnityEngine.Random;



public class ElegirCarta : MonoBehaviour
{

    public GameObject[] cartasBio, cartasMat, cartasHis, cartasPhy;
    public List<GameObject> listaBarajaCartas;

    public bool biology, physics, history, maths;

    int contador;
    public int numberOfQuestions;

    public int count;

    private void Start()
    {

        FabricarLista();

        count =listaBarajaCartas.Count;   


        
        
    }

    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Space) && numberOfQuestions>0)
        {

            EleccionCarta(); //Elige carta y si toca, se activa con 2 métodos


            count = listaBarajaCartas.Count;
        }
    }


    public void FabricarLista()
    {
        if (biology)
        {

            foreach (GameObject gO in cartasBio)
            {

                listaBarajaCartas.Add(gO);
            }
        }


        if (maths)
        {

            foreach (GameObject gO in cartasMat)
            {

                listaBarajaCartas.Add(gO);
            }
        }

        if (biology)
        {

            foreach (GameObject gO in cartasHis)
            {

                listaBarajaCartas.Add(gO);
            }
        }

        if (biology)
        {

            foreach (GameObject gO in cartasPhy)
            {

                listaBarajaCartas.Add(gO);
            }
        }
    }

    public void EleccionCarta()
    {
        numberOfQuestions--;

        int numeroAzar = Random.Range(0,listaBarajaCartas.Count-1);

        listaBarajaCartas[numeroAzar].SetActive(true);
        listaBarajaCartas.Remove(listaBarajaCartas[numeroAzar]);
        


    }

    public void ActivacionCarta(int num)
    {

        if (cartasBio[num].
                GetComponent<DatosDeLaCarta>().
                itWasUsed == false)
        {
            contador++;

            Debug.Log("La carta " + num + " es nueva");
            foreach (GameObject carta in cartasBio)
            {
                carta.SetActive(false);
                
            }

            Debug.Log(num);
           

            cartasBio[num].SetActive(true);

            cartasBio[num].GetComponent<DatosDeLaCarta>().itWasUsed = true;

            Debug.Log("Hecambiado el estado de it was used");

        }
        else
        {
            Debug.Log("La carta " + num + " ya ha sido elegida");
            EleccionCarta();
        }

        
    }
}