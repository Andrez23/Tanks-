using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetaxisyGetbutton : MonoBehaviour
{
    //Variables publicas
    //Translate
    public int speed; //declaramos una variable publica para poder modificarla desde Unity

    //Rotate
    public int turnSpeed;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log("Horizontal :" + horizontal); //Nos mostrará el valor de el movimiento horizontal. Es decir, cuando presionemos A o D, tendra un valor positivo o negativo, y cuando no presionemos nada, será 0
        Debug.Log("Vertical :" + vertical);//Lo mismo para el valor vertical, que nos mostrará 1 (cuando presionemos W), y -1 (cuando presionemos S), al igual que 0 cuanod no estemos presionando nada 

        transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontal);

    }
}
