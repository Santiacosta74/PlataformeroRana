using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent onBuscarColeccionables;

    private void Start()
    {
        if (onBuscarColeccionables == null)
            onBuscarColeccionables = new UnityEvent();
    }

    public void BuscarColeccionables()
    {
        Debug.Log("Buscando coleccionables...");
        // Implementa la lógica para buscar coleccionables en la escena
    }

    public void InvocarBuscarColeccionables()
    {
        onBuscarColeccionables.Invoke();
    }
}
