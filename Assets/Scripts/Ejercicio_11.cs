using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_11 : MonoBehaviour
{
    // 11. Realizá un programa que resuelva el siguiente problema:
    // Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
    // YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
    // producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
    // Modelo de Ticket:
    // Fecha de Compra: YYYYMMDD
    // Nombre del Comprador: xxxxx xxxxx
    // Producto solicitado: xxxxx
    // Cantidad solicitada: xx
    // Precio Unitario: $xxx
    // Total a Pagar: $xxxxx

    public string fechadecompra;
    public string nombrecomprador;
    public string nombreproducto;
    public int cantidadproducto;
    public int precioproducto;
    int preciototal;

    // Start is called before the first frame update
    void Start()
    {
        preciototal = precioproducto * cantidadproducto;
        Debug.Log("Fecha de Compra: " + fechadecompra + "\n Nombre del Comprador: " + nombrecomprador + "\n Producto solicitado: " + nombreproducto + "\n Cantidad solicitada: " + cantidadproducto + "\n Precio Unitario: " + precioproducto + "\n Total a pagar: " + preciototal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
