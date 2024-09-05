using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awakeyfixeupdate : MonoBehaviour
{
    //Este se ejecuta incluso antes que el start, y nos sirve para hacer referencia a los componentes
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Sabemos que el start se ejecuta una vez al inicio
    void Start()
    {
        Debug.Log("Start");
    }

    // Este se ejeucta al final, haciendolo en repetidas veces, es decir, una por cada frame
    void Update()
    {
        Debug.Log("Update: " + Time.deltaTime);
    }

    //Este se ejecuta cada 0.02 seg (este se usa a la hora de mover objetos por fisicas, ya que sus tiempos de carga son estables)
    private void FixedUpdate() 
    {
        Debug.Log("FixedUpdate: " + Time.deltaTime);
    }
}
