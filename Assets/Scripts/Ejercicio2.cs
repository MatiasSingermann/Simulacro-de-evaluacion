using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // 2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y
    // un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    // Luego indicar cuánto dinero sobra o falta.

    public float precio1;
    public float precio2;
    public float precio3;
    float preciototal;
    public float monto;
    float sobra;
    float falta;

    // Start is called before the first frame update
    void Start()
    {
        preciototal = precio1 + precio2 + precio3;

        if (monto >= preciototal)
        {
            Debug.Log("La suma de los precios no supera el monto disponible");
            sobra = monto - preciototal;
            Debug.Log("Sobran $" + sobra);
        }

        else
        {
            Debug.Log("La suma de los precios supera el monto disponible");
            falta = preciototal - monto;
            Debug.Log("Faltan $" + falta);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
