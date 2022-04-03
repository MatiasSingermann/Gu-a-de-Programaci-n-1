using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_13 : MonoBehaviour
{
    // 13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:
    // • Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    // • Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
    // por cada hora extra. (crear una constante para almacenar el 20)
    // Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
    // el salario correspondiente.

    public int horastrabajadas;
    int horastrabajadas40;
    const int primeras40horas = 16;
    const int despues40horas = 20;
    int horasdemas;
    int salariohorasdemas;
    int salariototal;

    // Start is called before the first frame update
    void Start()
    {
        if (horastrabajadas <= 40)
        {
            salariototal = primeras40horas * horastrabajadas;
        }

        else
        {
            horasdemas = horastrabajadas - 40;
            horastrabajadas40 = horastrabajadas - horasdemas;
            salariohorasdemas = horasdemas * despues40horas;
            salariototal = (primeras40horas * horastrabajadas40) + salariohorasdemas;
        }

        Debug.Log("El salario de la semana es de $" + salariototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
