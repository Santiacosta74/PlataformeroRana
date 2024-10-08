using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class AccionesJugador : MonoBehaviour
{
    public UnityEvent onSceneChange;

    public void SiguienteEscena()
    {
        onSceneChange.Invoke();
        int indiceEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceEscena + 1);
    }
}
