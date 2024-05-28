using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesJugador : MonoBehaviour
{
    GestionJugador gestion;
    MovimientoJugador movimiento;
    Rigidbody2D rb;
    Animator animador;
    SpriteRenderer sprite;

    private void Start()
    {
        gestion = GetComponent<GestionJugador>();
        movimiento = GetComponent<MovimientoJugador>();
        animador = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Correr();
        Saltar();
    }

    public void Correr()
    {
        if (movimiento.movimientoHorizontal != 0)
        {
            animador.SetFloat("xVelocity", movimiento.movimientoHorizontal);
        }
    }

    public void Saltar()
    {
        animador.SetBool("estaSaltando", movimiento.saltando);
        if (movimiento.saltando)
        {
            animador.SetFloat("yVelocity", rb.velocity.y);
        }
    }

    public void Daño()
    {
        animador.SetTrigger("estaDañado");
    }

    public void DeshabilitarSprite()
    {
        sprite.enabled = false;
    }
}
