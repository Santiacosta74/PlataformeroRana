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
        salud -= amount; // Resta la cantidad de da�o a la salud
        Debug.Log($"Jugador recibi� {amount} de da�o. Salud restante: {salud}");

        if (salud <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        // Implementa la l�gica de muerte del jugador aqu�
        Debug.Log("Jugador ha muerto.");
        // Aqu� puedes desactivar el jugador, mostrar una pantalla de Game Over, etc.
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
