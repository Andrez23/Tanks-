using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buclefor : MonoBehaviour
{
    public int num;  //declaracion de variable publica

    // Bucle for
    //Este se usa para acciones repetitivas las cuales al hacer algo cambia un numero determinado de veces
    void Start()
    {
        for (int i = 0; i < 10; i++)  
        {
            num = num + i;
            Debug.Log("El valor de num es igual a: " + num);
        }
        
    }

    //Acordarme que esta funcion se ejecuta por cada frame
    void Update()
    {
        
    }
}
