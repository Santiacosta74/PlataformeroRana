using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : Coleccionable
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        Recoger();
        AñadirVelocidad();
    }

    private void AñadirVelocidad()
    {
        // Esta función añadirá velocidad de movimiento
    }
}
