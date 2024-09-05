    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject spherePrefab; //Las necesitamos para poder acceder a su posicion y rotacion
    public Transform posRotSphere;
    void Start()
    {
        // Invocar el prefab, en un tiempo determinado
        //Invoke("CreateSphere", 1);  //COn el invoke llamamos el metodo, y decimos que en 4 segundos, debe aparecer el prefab

        //Invocar el prefab varias veces cada cierto tiempo
        //InvokeRepeating("CreateSphere", 2, 1);  
    }

    // Update is called once per frame                       
    void Update()                                           
    {
        
    }

    void CreateSphere()
    {
        Instantiate(spherePrefab, posRotSphere.position, posRotSphere.rotation);
    }
}
