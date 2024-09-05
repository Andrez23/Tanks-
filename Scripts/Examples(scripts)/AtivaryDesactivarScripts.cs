using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaryDesactivarScripts : MonoBehaviour
{
    public GameObject lighTank; //Creacion de variable publica y gameObject
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //Decimos que al presionar la p (Acordarse que "Down" es al presionar algo)
        {
            lighTank.SetActive(!lighTank.activeInHierarchy); //Lo que hace el hierarchy, es devolvernos en la jerarquia si esta activada cuando esta en true, o en false cuando no lo está 
        }
    }
}
