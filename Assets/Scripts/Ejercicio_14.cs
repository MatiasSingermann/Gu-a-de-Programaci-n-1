using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_14 : MonoBehaviour
{
    // 14. Construir un programa que simule el funcionamiento de una calculadora que puede
    // realizar las cuatro operaciones aritméticas básicas(suma, resta, producto y división) con valores numéricos enteros.
    // Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s
    // para la suma, r para la resta, p para el producto y d para la división) y luego, deberán
    // ingresarse dos números enteros para así realizar la operación.Informar el resultado por
    // pantalla.Nota: Se recomienda el empleo de una sentencia switch.

    public string operacion;
    public int num1;
    public int num2;
    int sumarnum;
    int restarnum;
    int multiplicarnum;
    float dividirnum;

    // Start is called before the first frame update
    void Start()
    {
        switch (operacion)
        {
            case "s":
                sumarnum = num1 + num2;
                Debug.Log("El resultado es " + sumarnum);
                break;
            case "r":
                restarnum = num1 - num2;
                Debug.Log("El resultado es " + restarnum);
                break;
            case "p":
                multiplicarnum = num1 * num2;
                Debug.Log("El resultado es " + multiplicarnum);
                break;
            case "d":
                dividirnum = num1 / num2;
                Debug.Log("El resultado es " + dividirnum);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
