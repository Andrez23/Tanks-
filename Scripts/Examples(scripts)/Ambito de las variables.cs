using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Accediendo al componente "Transform"
public class Loop : MonoBehaviour
{
    float xPosition;

    public int speed;  //Creando variable publica
 
    void Start()
    {
        //Leyendo el valor de posicion desde codigo
        xPosition = transform.position.x;   //Inicialización y se accede a la posicion en x
        Debug.Log("La posición de X en el transform es: " + xPosition); //Escribir en pantalla, su posicion


        //Asignar varlor a esa posición
        transform.position = new Vector3(5, transform.position.y, transform.position.z); //En el 5 damos nuevo valor, que equivale a la X, mientras que Y y Z, le decimos que se quede en la posicion orginal



        //Ambitos de variables
        Debug.Log("El valor de la velovidad es: "+ speed);

    }

    void Update()
    {
        
    }
}
