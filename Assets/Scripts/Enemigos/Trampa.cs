using UnityEngine;

public class Trampa : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.collider.gameObject); 
        }
    }
}
