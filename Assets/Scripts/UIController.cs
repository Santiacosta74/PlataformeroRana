using UnityEngine;
using UnityEngine.Events;

namespace PlataformaRana.UI
{
    public class UIController : MonoBehaviour
    {
        // Referencia al objeto Coin en la escena
        public Coin coin;

        void OnEnable()
        {
            if (coin != null)
            {
                coin.onCollected.AddListener(ActualizarPuntuacion);
            }
        }

        void OnDisable()
        {
            if (coin != null)
            {
                coin.onCollected.RemoveListener(ActualizarPuntuacion);
            }
        }

        void ActualizarPuntuacion()
        {
            // Implementa la lógica para actualizar la puntuación
            Debug.Log("Puntuación actualizada");
        }
    }
}
