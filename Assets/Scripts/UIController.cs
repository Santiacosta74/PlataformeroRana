using UnityEngine;
using UnityEngine.Events;

namespace PlataformaRana.UI
{
    public class UIController : MonoBehaviour
    {
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
            Debug.Log("Puntuación actualizada");
        }
    }
}
