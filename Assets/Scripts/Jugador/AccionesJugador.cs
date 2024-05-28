using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccionesJugador : MonoBehaviour
{
    GestionJugador gestion;

    private void Start()
    {
        gestion = GetComponent<GestionJugador>();
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Trampa") || colision.gameObject.CompareTag("Enemigo"))
        {
            gestion.RecibirDaño();
        }
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("Fin"))
        {
            SiguienteEscena();
        }
    }

    public void SiguienteEscena()
    {
        int indiceEscena = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indiceEscena + 1);
    }
}
