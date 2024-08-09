using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public UnityEvent onCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected.Invoke();
        }
    }
}

public class UIController : MonoBehaviour
{
    void OnEnable()
    {
        FindObjectOfType<Coin>().onCollected.AddListener(UpdateScore);
    }

    void OnDisable()
    {
        FindObjectOfType<Coin>().onCollected.RemoveListener(UpdateScore);
    }

    void UpdateScore()
    {
    }
}
