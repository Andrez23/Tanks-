using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    float xPosition;  //declaro variable boleanan
    void Start()
    {
        xPosition= transform.position.x; // Guardo la posicion de X en la variable

        if(xPosition > 5)  //Pongo el condicional y las condiciones
        {
            Debug.Log("La posicion del tanque en X es mayor a 5");
        }
        else if (xPosition <= 5 && xPosition >=3) //El else if, nos permte crear una nueva condicion si la del "if" no se cumple
        {
            Debug.Log("La posicion del tanque en X es menos que 5 y mayor o igual en 3");
        }
        else //Sabemos que el "else", se usa en caso de que la condicion del "if o el else-if" no se cumpla
        {
            Debug.Log("La posicion del tanque en X es menor a 3");
        }

        //Ejercicio (posiscion en Y)

        float yPosition = transform.position.y;

        if (yPosition > 1)
        {
            Debug.Log("Nuestro carro está en el aire");
        }
        else
        {
            Debug.Log("Está en el suelo");
        }

        //Ejercicio (cambiar su posicion en x)

        transform.position = new Vector3(30, transform.position.y,transform.position.z); 
    }

    void Update()
    {
        
    }
}
