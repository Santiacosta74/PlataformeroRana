using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje, IDamageable
{
    [SerializeField] private GameObject pie;
    private float radioVerificacionSuelo = 0.06f;

    public int salud = 100; 

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

    public void TakeDamage(int amount)
    {
        salud -= amount; 
        Debug.Log($"Jugador recibió {amount} de daño. Salud restante: {salud}");

        if (salud <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {

        Debug.Log("Jugador ha muerto.");

        gameObject.SetActive(false); 
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
