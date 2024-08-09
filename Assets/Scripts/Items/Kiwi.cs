using PlataformaRana.Items;
using UnityEngine;

public class Kiwi : Coleccionable
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Recoger();
            AñadirVelocidad();
            Destroy(gameObject); // Destruye el objeto al ser recogido
        }
    }

    private void AñadirVelocidad()
    {
        // Esta función añadirá velocidad de movimiento
    }
}
