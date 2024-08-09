using UnityEngine;

public class ManagerPowerUps : MonoBehaviour
{
    // Referencias a los prefabs de los diferentes power-ups
    public GameObject prefabPowerUpSaltoExtra;
    // Agrega m�s variables para otros tipos de power-ups seg�n necesites

    // M�todo para instanciar un power-up espec�fico en una posici�n
    public void InstanciarPowerUpSaltoExtra(Vector3 posicion)
    {
        Instantiate(prefabPowerUpSaltoExtra, posicion, Quaternion.identity);
    }

    // Agrega m�todos similares para otros tipos de power-ups

    // M�todo para aplicar un power-up espec�fico
    public void AplicarPowerUp(PowerUp powerUp)
    {
        powerUp.AplicarEfecto();
    }
}
