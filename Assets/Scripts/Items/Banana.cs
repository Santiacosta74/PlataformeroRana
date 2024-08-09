using PlataformaRana.Items;
using UnityEngine;

public class Banana : Coleccionable
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            Recoger();
            Destroy(gameObject); // Destruye el objeto al ser recogido
        }
    }
}
