using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    protected float vida;

    protected void PerderVida(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            // L�gica para cuando el enemigo muere
            Destroy(gameObject);
        }
    }
}
