using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Esta clase controla el movimiento del jugador.
public class PlayerMovement : MonoBehaviour
{
    // Variables que controlan la velocidad del movimiento y la rotación.
    // Se declaran aquí para que sean visibles y ajustables en el Inspector de Unity.
    public int speed;     // Velocidad de movimiento hacia adelante/atrás.
    public int turnSpeed; // Velocidad de rotación.

    // Variables para almacenar la entrada del jugador.
    // Se usan para capturar qué teclas se están presionando.
    public float h; // Entrada para izquierda/derecha.
    public float v; // Entrada para adelante/atrás.

    // El método Start se llama una vez al iniciar el juego.
    // Está aquí para cualquier configuración que necesite hacerse al principio.
    void Start()
    {
        // Este método está vacío, pero puede ser útil para configuraciones iniciales.
    }

    // El método Update se llama una vez por cada cuadro de juego.
    // Se utiliza para verificar la entrada del jugador y mover al personaje.
    void Update()
    {
        // Captura qué teclas está presionando el jugador.
        InputPlayer();

        // Mueve al jugador según la entrada capturada.
        Movement();
    }

    // Este método captura la entrada del jugador (teclado o controlador).
    // Está aquí para mantener el código organizado y fácil de entender.
    void InputPlayer()
    {
        // Captura la entrada de izquierda/derecha.
        h = Input.GetAxis("Horizontal");

        // Captura la entrada de adelante/atrás.
        v = Input.GetAxis("Vertical");
    }

    // Este método aplica el movimiento y la rotación del jugador.
    // Se separa para que sea más fácil de leer y modificar.
    void Movement()
    {
        // Mueve al jugador hacia adelante o hacia atrás según la entrada.
        // "v" es cuánto queremos movernos (adelante/atrás), multiplicado por la velocidad.
        // Time.deltaTime hace que el movimiento sea suave e independiente del framerate.
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);

        // Rota al jugador hacia la izquierda o derecha según la entrada.
        // "H" es cuánto queremos rotar, multiplicado por la velocidad de rotacion.
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);
    }
}


