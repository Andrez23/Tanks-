using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] nums;  //Este es un array de enteros  y publico, por ende damos los valores de la posicion desde el inspector

    float[] numbers = new float[7];
    void Start()
    {
        //Para acceder al valor de una casilla con su posicion

        /*Debug.Log("El valor de la casilla 1 es: " + nums[1]); */


        //Para acceder a los valores de todo el arreglo 

        /*for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log("El valor de la casilla es: "+ nums[i]);
        }*/

        //Para indicar el tamaño de un Array y que es privado

       for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = 2; //Ya que es un Array provado, necesitamos darle valor a las posiciones para que pueda mostrar en pantalla este mismo
            Debug.Log("El valor de la casilla es: " + numbers[i]);
        }

    }

    void Update()
    {
        
    }
}
