using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject ballPrefab; //Esta hace referencia al prefab que está en Assets, ya que para clonar, no se puede sacar un objeto de escena. Necesitamos el prefab orignial 
    public Transform positionBall;// Posicion de salida de la bala 

    public float forceBall; //Nos servirá para cambiar desde Unity, la feurza de la bola 

    public float timeBetweenAttacks; //Esta nos servirá para poder controlar el tiempo entre ataques desde Unity
    float timer; //Esta rije el tiempo en que puede atacar, nuesro contador 
    void Start()
    {
        
    }

    void Update() //Y como sabemos, el Update se ejecuta por cada frame, es decir que es repetitivo, por ende, llama a la funcion attack, para poder ejecutar el comnado del mouse
    {
        Attack();
    }

    void Attack() //Esta funcion se encarga de realizar la accion de "disparar" al presionar el mouse, llamanado a la funcion que crea el clon
    {
        //timer = timer + Time.deltaTime. Es lo mismo que +=
        timer += Time.deltaTime; //Contador de tiempo. Explicandolo de forma sencilla, quiere decir que timer equivaldrá al valor de Time.deltaTime, ya que sabemos que al ejecutarse, en este siempre pasa un tiempo determinado entre updates, por lo cual, ese valor se suma a timer

        if (Input.GetMouseButtonDown(0) && timer >= timeBetweenAttacks)
        {
            timer = 0; //Reinciamos el contador, para que antes de hacer el ataque, empieze a contar de nuevo y llegue al tiempo que pide la condicion
            CreateCloneBall();
        }
    }

    void CreateCloneBall()//Funcion que se encarga de crear el clon de la bala
    {
        GameObject cloneBall=Instantiate(ballPrefab, positionBall.position, positionBall.rotation); //Creamos variable que guarda al metodo que clona las balas

        Rigidbody rcCloneBall = cloneBall.GetComponent<Rigidbody>(); //Creamos variable para que con el GetComponent, no perdamos recursos ya que es pesado

        rcCloneBall.AddForce(Vector3.up * forceBall/2); //Con esto accedemos al Rigidbody (a traves de rcCloneBall) de la variable que contiene al clon de la bola y se le añade fuerza.
                                                        //Ademas, se divide entre 2, para que la feirza sea proporcional 

        rcCloneBall.AddForce(transform.forward * forceBall); //Ese "transform.forward", esta haciendo referencia al gameObject que tiene el script, por ende al moverse en eje z, y al disparar la bola, se moverá con el tanque

        Destroy(cloneBall, 5); //Le decimos que destruya los clones cada cierto tiempo

    }
}
