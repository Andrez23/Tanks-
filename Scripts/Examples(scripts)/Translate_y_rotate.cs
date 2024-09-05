using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translateyrotate : MonoBehaviour
{
    /*//Translate
    public int speed; //declaramos una variable publica para poder modificarla desde Unity

    //Rotate
    public int turnSpeed; 

    // No se hace aqui, ya que solo se ejecuta una vez
    void Start()
    {
        
    }

    // Si se hace aqui, ya que es una accion que se ejecuta varias veces 
    void Update()
    {
        transform.Translate(Vector3.forward * speed *Time.deltaTime);  // esta es para la traslacion
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime); // para la rotacion
    } */

    //Practica (trasladar y rotar)

    public int vel;
    public int rot;

    void Update()
    {
     transform.Translate(Vector3.forward* vel* Time.deltaTime);
     transform.Rotate(Vector3.up* rot* Time.deltaTime);
    }
}
