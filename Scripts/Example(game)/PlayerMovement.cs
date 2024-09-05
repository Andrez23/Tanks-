using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Esta clase controla el movimiento del jugador.
public class PlayerMovement : MonoBehaviour
{
    // Variables que controlan la velocidad del movimiento y la rotaci�n.
    // Se declaran aqu� para que sean visibles y ajustables en el Inspector de Unity.
    public int speed;     // Velocidad de movimiento hacia adelante/atr�s.
    public int turnSpeed; // Velocidad de rotaci�n.

    // Variables para almacenar la entrada del jugador.
    // Se usan para capturar qu� teclas se est�n presionando.
    public float h; // Entrada para izquierda/derecha.
    public float v; // Entrada para adelante/atr�s.

    // El m�todo Start se llama una vez al iniciar el juego.
    // Est� aqu� para cualquier configuraci�n que necesite hacerse al principio.
    void Start()
    {
        // Este m�todo est� vac�o, pero puede ser �til para configuraciones iniciales.
    }

    // El m�todo Update se llama una vez por cada cuadro de juego.
    // Se utiliza para verificar la entrada del jugador y mover al personaje.
    void Update()
    {
        // Captura qu� teclas est� presionando el jugador.
        InputPlayer();

        // Mueve al jugador seg�n la entrada capturada.
        Movement();
    }

    // Este m�todo captura la entrada del jugador (teclado o controlador).
    // Est� aqu� para mantener el c�digo organizado y f�cil de entender.
    void InputPlayer()
    {
        // Captura la entrada de izquierda/derecha.
        h = Input.GetAxis("Horizontal");

        // Captura la entrada de adelante/atr�s.
        v = Input.GetAxis("Vertical");
    }

    // Este m�todo aplica el movimiento y la rotaci�n del jugador.
    // Se separa para que sea m�s f�cil de leer y modificar.
    void Movement()
    {
        // Mueve al jugador hacia adelante o hacia atr�s seg�n la entrada.
        // "v" es cu�nto queremos movernos (adelante/atr�s), multiplicado por la velocidad.
        // Time.deltaTime hace que el movimiento sea suave e independiente del framerate.
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);

        // Rota al jugador hacia la izquierda o derecha seg�n la entrada.
        // "H" es cu�nto queremos rotar, multiplicado por la velocidad de rotacion.
        transform.Rotate(Vector3.up * h * turnSpeed * Time.deltaTime);
    }
}


