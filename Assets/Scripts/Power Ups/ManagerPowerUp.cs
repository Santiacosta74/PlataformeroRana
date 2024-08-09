using UnityEngine;

public class ManagerPowerUps : MonoBehaviour
{
    // Referencias a los prefabs de los diferentes power-ups
    public GameObject prefabPowerUpSaltoExtra;
    // Agrega más variables para otros tipos de power-ups según necesites

    // Método para instanciar un power-up específico en una posición
    public void InstanciarPowerUpSaltoExtra(Vector3 posicion)
    {
        Instantiate(prefabPowerUpSaltoExtra, posicion, Quaternion.identity);
    }

    // Agrega métodos similares para otros tipos de power-ups

    // Método para aplicar un power-up específico
    public void AplicarPowerUp(PowerUp powerUp)
    {
        powerUp.AplicarEfecto();
    }
}
