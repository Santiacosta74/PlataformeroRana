using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoPinchos : Enemigo
{
    private void OnTriggerEnter2D(Collider2D colision)
    {
        PerderVida(1f);
    }

    void MovimientoAleatorio()
    {
        // El enemigo se moverá de forma vertical u horizontal de forma aleatoria
    }
}
