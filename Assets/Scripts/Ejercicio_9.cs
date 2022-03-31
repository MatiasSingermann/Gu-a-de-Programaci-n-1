using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_9 : MonoBehaviour
{
    // 9. Realizá un programa que resuelva el siguiente problema:
    // Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
    // total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado por las tres.
    // Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego mostrar lo pedido en el siguiente formato:
    // Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

    public string nombre1;
    public float aporte1;
    float porcentaje1;
    public string nombre2;
    public float aporte2;
    float porcentaje2;
    public string nombre3;
    public float aporte3;
    float porcentaje3;
    float montototal;

    // Start is called before the first frame update
    void Start()
    {
        montototal = aporte1 + aporte2 + aporte3;

        porcentaje1 = aporte1 / montototal * 100;
        porcentaje2 = aporte2 / montototal * 100;
        porcentaje3 = aporte3 / montototal * 100;

        Debug.Log("Nombre: " + nombre1 + " Capital aportado: $" + aporte1 + " Porcentaje del capital: %" + porcentaje1 + " Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre2 + " Capital aportado: $" + aporte2 + " Porcentaje del capital: %" + porcentaje2 + " Monto total aportado: $" + montototal);
        Debug.Log("Nombre: " + nombre3 + " Capital aportado: $" + aporte3 + " Porcentaje del capital: %" + porcentaje3 + " Monto total aportado: $" + montototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
