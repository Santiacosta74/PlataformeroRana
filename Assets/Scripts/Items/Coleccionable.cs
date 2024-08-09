using UnityEngine;

namespace PlataformaRana.Items // Aseg�rate de que el espacio de nombres sea correcto
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
            // Implementa la l�gica de recoger el coleccionable
            Destroy(gameObject);
        }
    }
}
