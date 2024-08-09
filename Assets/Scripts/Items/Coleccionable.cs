using UnityEngine;

namespace PlataformaRana.Items
{
    public class Coleccionable : MonoBehaviour
    {
        public PowerUp powerUp;

        public PowerUp ObtenerPowerUp()
        {
            return powerUp;
        }

        public void Recoger()
        {
            // Implementa la lógica de recoger el coleccionable
            PowerUp powerUp = ObtenerPowerUp();
            if (powerUp != null)
            {
                powerUp.AplicarEfecto();
            }
            Destroy(gameObject);
        }
    }
}
