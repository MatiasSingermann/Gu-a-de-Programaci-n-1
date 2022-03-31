using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_7 : MonoBehaviour
{
    // 7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3,
    // muestre el valor del mayor de todos. 
    // En caso de igualdad entre los tres imprimir "Los números son iguales".


    public int num1;
    public int num2;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 & num1 > num3 | num1 == num2 & num1 > num3 | num1 == num3 & num1 > num2)
        {
            Debug.Log("El valor más alto es " + num1);
        }

        else if (num2 > num1 & num2 > num3 | num2 == num1 & num2 > num3 | num2 == num3 & num2 > num1)
        {
            Debug.Log("El valor más alto es " + num2);
        }

        else if (num3 > num1 & num3 > num2 | num3 == num1 & num3 > num2 | num3 == num2 & num3 > num1)
        {
            Debug.Log("El valor más alto es " + num3);
        }

        else
        {

            Debug.Log("Son los 3 iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
