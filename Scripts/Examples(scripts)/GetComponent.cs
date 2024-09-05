using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    Light lightTank;  //Para poder acceder con la variable, debemos crear una, que sea de tipo componente
    void Start()
    {
       lightTank= GetComponent<Light>();  //Ahora, guardamor el getComponent, que contiene al componente Light y lo guardamos en nuestra variable 
    }

    void Update() //Con este desactivamos un componente, que es diferente a desactivar o activar un gameobject
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Primer forma(no efectiva)

            /*GetComponent<Light>().enabled = false;   -Con este, le decimos que acceda al componente light, y que con el .enable, lo desactive, (que es el false)
                                                       -Este no es muy efectivo, por ende, podemos hacerlo de otra forma, ya que cuando queramos acceder, no necesitaremos estar escribiendo el getComponent a cada rato, solo con acceder a la variable, es suficiente. */

            //Segunda forma (forma efectiva)

            /*if (Input.GetKeyDown(KeyCode.P))
            {
                lightTank.enabled = false;  Y ya con eso, cada vez que deseemos desactivar el componente no tendremos que acceder al getComponent, solo tendremos que usar la variable
            } */

            //Tercera forma (en una sola linea)

            if (Input.GetKeyDown(KeyCode.P))
            {
                bool stateLight= lightTank.enabled;     //Creamos una varibale local, donde guardaremos el estado de la luz, asi, despues cambiando su estado (si esta apagada, cambia a encedida, y viceversa)
                lightTank.enabled = !stateLight;
            }
        }
    }
}
