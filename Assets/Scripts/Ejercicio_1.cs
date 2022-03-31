using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{

    // Realizá un programa donde se declare una variable entera num1, que inicialmente valdrá cero.
    // Luego incrementá su valor en 2 y mostralo por pantalla.
    // Después mostrá el resultado de multiplicarlo por sí mismo una vez.

    int num1;

    // Start is called before the first frame update
    void Start()
    {
        num1 = 0;
        num1 = num1 += 2;
        Debug.Log(num1);
        num1 = num1 * num1;
        Debug.Log(num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
