using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Tank; //Con esto estamos creando una varibale tipo game object, que hace refenrecia a un elemento de la escena. O sea, guardaremos exculisivamente un gameobject en esta

    void Start()
    {
        
    }

    void Update()  //Va en el update, ya que necesita ejecutarse varias veces por frame
    {
        transform.LookAt(Tank.transform);   //Con el .transform, accedemos a su componente
    }
}
