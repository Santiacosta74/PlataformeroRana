using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorJuego : MonoBehaviour
{
    [SerializeField] GameObject fin;
    public int contadorObjetos;

    private void Start()
    {
        BuscarColeccionables();
    }

    private void FixedUpdate()
    {
        BuscarColeccionables();
    }

    public void BuscarColeccionables()
    {
        GameObject[] objetosEncontrados = GameObject.FindGameObjectsWithTag("Collectible");
        contadorObjetos = objetosEncontrados.Length;

        if (contadorObjetos == 0)
        {
            ActivarFin();
        }
    }

    void ActivarFin()
    {
        fin.SetActive(true);
    }
}
