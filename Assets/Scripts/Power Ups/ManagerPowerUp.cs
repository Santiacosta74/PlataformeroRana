using UnityEngine;

public class ManagerPowerUps : MonoBehaviour
{
    // Referencias a los prefabs de los diferentes power-ups
    public GameObject prefabPowerUpSaltoExtra;
    public void InstanciarPowerUpSaltoExtra(Vector3 posicion)
    {
        Instantiate(prefabPowerUpSaltoExtra, posicion, Quaternion.identity);
    }

    // M�todo para aplicar un power-up espec�fico
    public void AplicarPowerUp(PowerUp powerUp)
    {
        powerUp.AplicarEfecto();
    }
}
