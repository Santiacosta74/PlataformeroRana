using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"El enemigo recibi� {amount} de da�o, salud restante: {health}");

        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("Enemigo muerto");
    }
}

