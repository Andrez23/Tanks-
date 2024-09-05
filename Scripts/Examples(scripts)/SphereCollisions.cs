using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollisions : MonoBehaviour
{
    //OnCollisionEnter: este es el que nos da el momento en que los objetos acaban de colisionar. En este caso, acaba de colisionar con el suelo.
    /*private void OnCollisionEnter(Collision collision)  
    {
        Debug.Log("La esfera acaba de colisionar con algo");
    }*/

    //Ejemplo, de si necsitamos saber con que está colisionando nuestro objeto
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Debug.Log("He colisionado con el suelo");
        }
    }

    //Ejemplo, para mostrar cuando se está ejecutando y colisionando
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Debug.Log("Estoy colisionado con el suelo");
        }
    }

    //Ejemplo con Trigger, que hace que el gameObject, traspase y no colisione fisicamente
    private void OnTriggerEnter(Collider pepa)  //"pepa", es el nombre de la variable, que podemos poner con el nombre que deseemos
    {
        if (pepa.CompareTag("Ground"))
        {
            Debug.Log("He atravesado el suelo");        //NOTA: para que este script funcione, debemos activar el "Is Triiger" del objeto
        }
    }
}

