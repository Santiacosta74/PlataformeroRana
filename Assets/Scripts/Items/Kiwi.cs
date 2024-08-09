using PlataformaRana.Items;
using UnityEngine;

public class Kiwi : Coleccionable
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Recoger();
            PowerUp powerUp = GetComponent<PowerUp>();
            if (powerUp != null)
            {
                powerUp.AplicarEfecto();
            }
            Destroy(gameObject);
        }
    }
}
