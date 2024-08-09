using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    [SerializeField] private GameObject pie;
    private float radioVerificacionSuelo = 0.06f;

    public new void Start()
    {
        fuerzaSalto = 4f;
        velocidad = 1.9f;
        base.Start();
    }

    public void AgregarSaltoExtra(float aumentoFuerza)
    {
        fuerzaSalto += aumentoFuerza;
    }

    public void AgregarVelocidadExtra(float aumentoVelocidad)
    {
        velocidad += aumentoVelocidad;
    }

    private void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");

        Mover(MovimientoHorizontal);
        Rotar(MovimientoHorizontal);

        VerificarSuelo(pie, radioVerificacionSuelo);
        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }
    }
}
