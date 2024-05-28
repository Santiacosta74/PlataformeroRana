using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Coleccionable
{
    private void OnCollisionEnter2D(Collision2D colision)
    {
        Recoger();
        AñadirSalto();
    }

    void AñadirSalto()
    {
        // Esta función añadirá fuerza de salto
    }
}
