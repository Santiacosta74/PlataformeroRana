using UnityEngine;

namespace PlataformaRana.Items // Asegúrate de que el espacio de nombres sea correcto
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
            Destroy(gameObject);
        }
    }
}
