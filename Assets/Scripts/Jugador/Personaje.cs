using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase base será para todos los personajes del juego
public class Personaje : MonoBehaviour
{
    protected float fuerzaSalto;
    protected float velocidad;

    protected Rigidbody2D rb2D;
    protected bool enSuelo;


    public float MovimientoHorizontal { get; protected set; }
    public bool Saltando { get; protected set; }

    protected virtual void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    protected void Mover(float direccion)
    {
        rb2D.velocity = new Vector2(direccion * velocidad, rb2D.velocity.y);
    }

    protected void Saltar()
    {
        if (enSuelo)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, fuerzaSalto);
        }
    }

    // Para rotar al personaje según la dirección del movimiento
    protected void Rotar(float direccion)
    {
        if (direccion < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (direccion > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    // Para verificar si el personaje está en el suelo
    protected void VerificarSuelo(GameObject pie, float radioVerificacionSuelo)
    {
        int layerMask = 1 << 7;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(pie.transform.position, radioVerificacionSuelo, layerMask);
        enSuelo = colliders.Length > 0;
        Saltando = !enSuelo;
    }
}
