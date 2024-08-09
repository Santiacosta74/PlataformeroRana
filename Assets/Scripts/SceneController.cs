using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneController : MonoBehaviour
{
    public UnityEvent onSiguienteEscena;

    void Start()
    {
        if (onSiguienteEscena == null)
            onSiguienteEscena = new UnityEvent();
    }

    public void SiguienteEscena()
    {
        int indiceEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceEscena + 1);
        onSiguienteEscena.Invoke();
    }
}
