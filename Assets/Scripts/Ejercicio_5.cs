using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_5 : MonoBehaviour
{
    // 5. Realizá un programa que, dados dos números enteros num1 y num2 cargados desde
    // el Inspector muestre el resultado de la división del primero por el segundo en la consola
    // siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.  
    // En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:
    // “No se puede dividir por cero”.

    public int num1;
    public int num2;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 / num2;

        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por cero");
        }

        else
        {
            Debug.Log(num1 + " / " + num2 + " = " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
