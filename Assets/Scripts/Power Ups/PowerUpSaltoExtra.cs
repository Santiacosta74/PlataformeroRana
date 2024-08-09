using UnityEngine;

public class PowerUpSaltoExtra : PowerUp
{
    public float aumentoFuerzaSalto = 2.0f;

    public override void AplicarEfecto()
    {
        Jugador jugador = FindObjectOfType<Jugador>();
        if (jugador != null)
        {
            jugador.AgregarSaltoExtra(aumentoFuerzaSalto);
        }
    }
}
