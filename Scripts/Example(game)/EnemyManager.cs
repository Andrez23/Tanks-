using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject tankEnemyPrefab; //Esta variable hace referencia al prefaboriginal (del tanque enemigo-rojo)
    public Transform[] positionsEnemy; //Estamos haciedno referencia a las 4 posiciones donde apareceran los tankes. Ademas de crear un arreglo donde guardaremos las posiciones del tanque 
    public float time; //Esta variable es para poner el tiempo en que demora en aparecer el primero, y despues la cantidad de tiempo que hay entre los demas objetos
    public Transform parentEnemies; //Nor srive para gestionar quien será el padre de los nuevos objetos que se crearán, y asi se mantenadrá el orden en al jerarquia
    void Start()
    {
        InvokeRepeating("CreateEnemies", time, time); //Con esto invocamos la funcion de clonar, para que se repita cada cierto tiempo. Es decir, que aprezcan enemigos cada cierto tiempo
    }

    void CreateEnemies() //Creamos una funcion que nos permita clonar(instanciar) a los tankes enemigos 
    {
        int n= Random.Range(0, positionsEnemy.Length); //Este devuelve numeros ramdom desde el 0 hasta la longitud maxima del arreglo, pero no su ultima casilla. Es decir, devuleve esa longitud-1, en este cas0 3, ya que 4 es la cantidad maxima
        GameObject cloneTankEnemy= Instantiate(tankEnemyPrefab, positionsEnemy[n].position, positionsEnemy[n].rotation); //Ya que se necesita saber que casilla elegira para crear el tanke, necesitamos crear algo que nos de las casillas aleatorias para poder usar el array
        cloneTankEnemy.transform.SetParent(parentEnemies); //Con esto le estamos diciendo que la variable que tengo como creadora de los clones, que los ponga como hijos (con el setParent) y acceda al transform para poder saber quien es el padre de estos objetos creados(clones de tanque enemigo                     )
    }
}
