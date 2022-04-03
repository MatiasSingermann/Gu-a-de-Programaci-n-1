using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_15 : MonoBehaviour
{
    // 15. Existen dos reglas que identifican dos conjuntos de valores:
    // - El número es de un solo dígito.
    // - El número es impar.
    // A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
    // estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
    // para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
    // ninguno, respectivamente.Definí un lote de prueba de varios números y probá el algoritmo,
    // escribiendo los resultados.
    // Lote de prueba: 2, 3, 5, 10, -11

    public int num;
    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool noEstaEnNinguno;

    // Start is called before the first frame update
    void Start()
    {
        if (num! < -9 & num! > 9)
        {
            estaEnA = true;
            Debug.Log("El número es de un solo dígito");
        }

        else if (num % 2 > 0)
        {
            estaEnB = true;
            Debug.Log("El número es impar");
        }

        else if (estaEnA == true & estaEnB == true)
        {
            estaEnAmbos = true;
            Debug.Log("El número cumple con las 2 reglas");
        }

        else
        {
            noEstaEnNinguno = true;
            Debug.Log("El número no cumple con ninguna de las 2 reglas");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
