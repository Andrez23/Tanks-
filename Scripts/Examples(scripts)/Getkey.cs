using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getkey : MonoBehaviour
{
    /*//Translate
    public int speed; //declaramos una variable publica para poder modificarla desde Unity

    //Rotate
    public int turnSpeed;

    void Start()
    {
        
    }

    // Se hace desde aquí, ya que este se ejecuta varias veces por frame, mientras que el start, solo una
    void Update()
    {
        if (Input.GetKey(KeyCode.W))  //El GetKey, siempre es true cuando presionamos la tecla que el input pide. Y de eso, se ejecutará 
        {
            transform.Translate(Vector3.forward* speed* Time.deltaTime); //trasalcion positiva
        }
        else if (Input.GetKey(KeyCode.S)) //Este hace que se traslade hacia atras
        {
            transform.Translate(-Vector3.forward*speed* Time.deltaTime);//traslacion negativa
        } 
        
    }*/


    //Practica (rotas y trasladar con input)

    public int vel;
    public int rot;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*vel*Time.deltaTime);
        }    
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.up*rot*Time.deltaTime);
        }
    }
}
