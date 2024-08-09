using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"El enemigo recibió {amount} de daño, salud restante: {health}");

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

