using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    protected float vida;

    protected void PerderVida(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            // Lógica para cuando el enemigo muere
            Destroy(gameObject);
        }
    }
}
