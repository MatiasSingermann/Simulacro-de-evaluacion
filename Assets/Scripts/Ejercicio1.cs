using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // 1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.

    public int numero1;
    public int numero2;

    // Start is called before the first frame update
    void Start()
    {
        if (numero1 == numero2)
        {
            Debug.Log("Los valores son iguales");
        }

        else
        {
            Debug.Log("Los valores son distintos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
