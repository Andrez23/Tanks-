using System;
using System.Collections;             //Librerias que nos permiten trabajar con Unity
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour     //Clases: son las que nos permiten crear cada accion para nuestro programa o juego
{
    //Declaracion de variable: TipoDato+NombreVariable
    int life;
    int power;
    float jumpForce;
    string namePlayer;

    // Start is called before the first frame update   -Metodos: estos dos que hay aqui, son los metodos, que vienen por defecto con Unity
    void Start()
    {
        //Inicialización de variable: NombreVariable+Valor
        life = 5; 
        power = 2;
        jumpForce = 50.5f; // Al declarar e inicializar un flotante con su decimal, debemos poner siempre una f
        namePlayer = "Andres";
        


        //Mostrar mensajes en consola
        Debug.Log("Holi");  //Con cadenas de texto
        Debug.Log(life);  //Mostrar directamente con el valor de la variable
        Debug.Log("Holi, el valor de la vaiable life es: "+ life); //Concatenando strings con variables



        //Operaciones con variables (multiplicacion)
        life = 5 * 2;
        Debug.Log("Holi, el valor de la vaiable life es: " + life); //Concatenando strings con variables

        //Multiplicacion (actulizacion de valor a una variable)
        life = life * power;

        //Operaciones con floats
        Debug.Log("El valor del salto es: " + jumpForce);

        //Operaciones con cadenas de caracateres
        Debug.Log("El nombre del jugador es: " + namePlayer);


        //Practica de operaciones

        //Suma

        int num1 = 12;
        int num2 = 8;

        int resul= num1 + num2;
        Debug.Log("El resultado de la suma es: " + resul);

        //Resta

        int res1 = 25;
        int res2 = 7;

        int resRest= res1 - res2;
        Debug.Log("El resultado de la resta es: " + resRest);

        //Multiplicacion

        int mult1 = 9;
        int mult2 = 5;

        int multResul= mult1 * mult2;
        Debug.Log("El resultado de la multiplicacion es: " + multResul);

        //Division

        int Div1 = 100;
        int Div2 = 4;

        int resulDiv= Div1 / Div2;
        Debug.Log("El resultado de la division es: " + resulDiv);

        //Resto o modulo

        int mod1 = 29;
        int mod2 = 6;

        int modResul= mod1 % mod2;
        Debug.Log("El resultado del modulo entre " + mod1 + " y " + mod2 + " es igual a: " + modResul);

        //Operaciones combinadas

        int comb1 = 15;
        int comb2 = 3;
        int comb3 = 7;

        int combResul= (comb1+ comb2) * comb3 - (comb2 / comb1);
        Debug.Log("El resultado es: " + combResul );



        //Llamada a la función
        MyFunction();  //Es muy importante llamar a la funcion, para que esta se pueda ejecutar. Ademas se hace en la funcion "start", para que Unity pueda leerla al inicio
    }



    //Declaración de funciones
    void MyFunction()
    {
        Debug.Log("Esta es mi primera función");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
