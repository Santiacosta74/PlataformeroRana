using PlataformaRana.Items;
using UnityEngine;

public class Kiwi : Coleccionable
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Recoger();
            A�adirVelocidad();
            Destroy(gameObject); // Destruye el objeto al ser recogido
        }
    }

    private void A�adirVelocidad()
    {
        // Esta funci�n a�adir� velocidad de movimiento
    }
}
