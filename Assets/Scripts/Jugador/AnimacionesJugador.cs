using UnityEngine;
using UnityEngine.Events;

public class AnimacionesJugador : MonoBehaviour
{
    public UnityEvent onRun;
    public UnityEvent onJump;
    public UnityEvent onTakeDamage;

    private MovimientoJugador movimiento;
    private Rigidbody2D rb;
    private Animator animador;
    private SpriteRenderer sprite;

    private void Start()
    {
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
            onRun.Invoke();
        }
    }

    public void Saltar()
    {
        animador.SetBool("estaSaltando", movimiento.saltando);
        if (movimiento.saltando)
        {
            animador.SetFloat("yVelocity", rb.velocity.y);
            onJump.Invoke();
        }
    }

    public void Daño()
    {
        animador.SetTrigger("estaDaño");
        onTakeDamage.Invoke();
    }

    public void DeshabilitarSprite()
    {
        sprite.enabled = false;
    }
}
