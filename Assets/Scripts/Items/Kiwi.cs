using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : Coleccionable
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        Recoger();
        A�adirVelocidad();
    }

    private void A�adirVelocidad()
    {
        // Esta funci�n a�adir� velocidad de movimiento
    }
}
