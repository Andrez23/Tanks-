using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tantiate : MonoBehaviour
{
    public GameObject SpherePrefab; // Debemos tener en cuenta que se debe hacer referencia a nuestro prefab
    public Transform posRotSphere; // Con este, accederemos a la rotacion de nuestro game object   NOTA: Acordarse que estas variables al ser publicas, debemos organizarlas desde Unity, llevando el objeto a la parte del script en el inspector

    void Start()
    {
        
    }

    // Se hace aqui, ya que se ejecuta muchas veces por frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Instantiate(SpherePrefab, posRotSphere.position , posRotSphere.rotation);
                                        //Con esto estamos dando la posiscion en que apareceran los clones
        }
    }
}
