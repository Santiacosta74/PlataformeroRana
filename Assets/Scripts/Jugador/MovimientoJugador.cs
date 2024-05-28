using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    float fuerzaSalto = 4f;
    float radioVerificacionSuelo = 0.06f;
    float velocidad = 2f;

    private Rigidbody2D rb2D;
    private bool enSuelo;

    [SerializeField] GameObject pie;

    public float movimientoHorizontal;
    public bool saltando;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        {
            movimientoHorizontal = Input.GetAxis("Horizontal");
            rb2D.velocity = new Vector2(movimientoHorizontal * velocidad, rb2D.velocity.y);

            RotarHaciaDireccionMovimiento(movimientoHorizontal);
        } // movimiento

        {
            EstaEnSuelo();
            if (Input.GetButtonDown("Jump") && enSuelo)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, fuerzaSalto);
            }
        } // acción de salto
    }

    private void EstaEnSuelo()
    {
        int layerMask = 1 << 7; // Solo verifica la capa 7
        Collider2D[] colliders = Physics2D.OverlapCircleAll(pie.transform.position, radioVerificacionSuelo, layerMask);
        enSuelo = colliders.Length > 0;
        saltando = !enSuelo;
    } // verifica si el jugador está en el suelo o no

    private void RotarHaciaDireccionMovimiento(float movimientoHorizontal)
    {
        if (movimientoHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (movimientoHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    } // rota el jugador hacia la dirección del movimiento
}
