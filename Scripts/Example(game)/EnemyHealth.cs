using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    /* private void OnCollisionEnter(Collision collision)  //A traves de la variable "collision" puedo saber con qeu objeto estoy colisionando. Es decir, si soy un enemigo, puedo saber que algun objeto me impactó
     {                                                   //Para eso, debemos añadirle una etiqueta al objeto (bala), para poder identificar que y quien esta chocando con el enemigo

         if (collision.collider.CompareTag("Ball"))  //Atraves de "collision", puedo acceder a "collider", que es el colider de la bala. Ademas, de que con "CompareTag" miro si es la bala en efecto y checo si está chocando con el enemigo
         {
             Destroy(collision.gameObject);  //Destruyo la bala
                                             //Resumen claro
                                             //collision guarda toda la información sobre la colisión, es decir, que guarda informacion del onjeto que colisionó con el enemigo, en este caso la bala
                                             //collision.gameObject es el objeto que chocó (la bala). Ya que al collision guardar info de la bala, se sabe que es esta
                                             //Al usar Destroy(collision.gameObject);, le dices a Unity que destruya ese objeto específico que chocó con el enemigo.

             Destroy(gameObject); //Destruyo el enemigo
                                  //No necesitas dar una referencia específica porque gameObject siempre se refiere al objeto(al enemigo en este caso) al que pertenece el script que lo llama. Así que cuando llamas a Destroy(gameObject);, le estás diciendo al juego que destruya el enemigo porque ese es el objeto al que pertenece el script EnemyHealth
         }
     } */

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {                                                    //NOTA IMPORTANTE: acordarse de marcar en el componente "Sphere collider" del objeto(bala), como IsTrigger, para que pueda funcionar
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}