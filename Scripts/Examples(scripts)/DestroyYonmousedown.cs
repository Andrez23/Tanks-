using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyYonmousedown : MonoBehaviour
{
    public float time; //Esta es para poder modificar el tiempo de destruccion desde Unity, por eso es publica
    public GameObject sphere; //La creamos para poder llevar el gameobject, al componente script del tanque

    //Lo usamos para que cuando presionemos el gameObject, este haga alguna accion
    private void OnMouseDown()
    {
        //Para destruir el objeto
        /*Debug.Log("Estamos destruyendo el gameObject");
        Destroy(gameObject); -Con esto, destruimos al tanke, ya que es el gameObject, que contiene al script */

        //Para destruir el objeto en un tiempo determinado- Para eso debemos crear una variable pubica para poder cambiar el valor del tiempo en que se destruye, desde Unity
        /*Debug.Log("Estamos destruyendo el gameObject");
        Destroy(gameObject,time); */

        //Para destruir el objeto no perteneciente al script
         Debug.Log("Estamos destruyendo el gameObject");
         Destroy(sphere,time);
    }
}