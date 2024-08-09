using UnityEngine;

public class PowerUpVelocidadExtra : PowerUp
{
    public float aumentoVelocidad = 2.0f;

    public override void AplicarEfecto()
    {
        Jugador jugador = FindObjectOfType<Jugador>();
        if (jugador != null)
        {
            jugador.AgregarVelocidadExtra(aumentoVelocidad);
        }
    }
}
