using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Coleccionable
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        Recoger();
        A�adirSalto();
    }

    void A�adirSalto()
    {
        // Esta funci�n a�adir� fuerza de salto
    }
}
