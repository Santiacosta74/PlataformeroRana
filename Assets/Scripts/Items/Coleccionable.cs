using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coleccionable : MonoBehaviour
{
    Animator animador;

    protected virtual void Start()
    {
        animador = GetComponent<Animator>();
    }

    protected void Recoger()
    {
        animador.SetTrigger("Recogido");
        Desaparecer();
    }

    public void Desaparecer()
    {
        Destroy(gameObject);
    }
}
