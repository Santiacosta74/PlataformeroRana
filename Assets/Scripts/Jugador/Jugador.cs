using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje, IDamageable
{
    [SerializeField] private GameObject pie;
    private float radioVerificacionSuelo = 0.06f;

    public int salud = 100; // Agrega una variable para la salud del jugador

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
        salud -= amount; // Resta la cantidad de daño a la salud
        Debug.Log($"Jugador recibió {amount} de daño. Salud restante: {salud}");

        if (salud <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        // Implementa la lógica de muerte del jugador aquí
        Debug.Log("Jugador ha muerto.");
        // Aquí puedes desactivar el jugador, mostrar una pantalla de Game Over, etc.
        gameObject.SetActive(false); // Ejemplo de desactivar el GameObject del jugador
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
