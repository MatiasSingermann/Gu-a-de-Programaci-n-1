using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_12 : MonoBehaviour
{
    // 12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
    // obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes resultados:
    // • Si los tres dados son seis, mostrar el mensaje “Excelente”
    // • Si dos dados son seis, mostrar el mensaje “Muy bien”
    // • Si un dado es seis, mostrar el mensaje “Regular”
    // • Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”

    public int puntaje1;
    public int puntaje2;
    public int puntaje3;
    int puntajetotal;

    // Start is called before the first frame update
    void Start()
    {
        puntajetotal = puntaje1 + puntaje2 + puntaje3;


        switch (puntajetotal)
        {
            case 18:
                Debug.Log("Excelente");
                break;

            case 12:
                Debug.Log("Muy bien");
                break;

            case 6:
                Debug.Log("Regular");
                break;

            default:
                Debug.Log("Insuficiente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
