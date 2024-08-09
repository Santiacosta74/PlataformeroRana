using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase Jugador que hereda de la clase Personaje
public class Jugador : Personaje
{
    [SerializeField] private GameObject pie; 
    private float radioVerificacionSuelo = 0.06f; 

    public new void Start()
    {
        fuerzaSalto = 4f;
        velocidad = 1.9f;
        base.Start();
    }
    public void AgregarSaltoExtra(float aumentoFuerza)
    {
        fuerzaSalto += aumentoFuerza; 
    }
    private void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");

        Mover(MovimientoHorizontal);
        Rotar(MovimientoHorizontal);

        VerificarSuelo(pie, radioVerificacionSuelo);
        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }
    }
}
