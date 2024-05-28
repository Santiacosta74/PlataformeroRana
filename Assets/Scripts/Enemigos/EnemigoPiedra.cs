using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPiedra : Enemigo
{
    private void OnTriggerEnter2D(Collider2D colision)
    {
        PerderVida(1f);
    }

    void Golpear()
    {
        // El enemigo golpeará el suelo cuando el jugador pase por debajo
    }
}
