using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// clase Jugador que hereda de la clase Personaje
public class Jugador : Personaje
{
    [SerializeField] private GameObject pie; // objeto que representa el pie del jugador para verificar el suelo
    private float radioVerificacionSuelo = 0.06f; // radio para la verificaci�n del suelo

    public new void Start()
    {
        fuerzaSalto = 4f;
        velocidad = 1.9f;
        base.Start();
    }

    private void Update()
    {
        MovimientoHorizontal = Input.GetAxis("Horizontal");

        // mueve y rota al jugador seg�n el movimiento horizontal
        Mover(MovimientoHorizontal);
        Rotar(MovimientoHorizontal);

        // verifica si el jugador est� en el suelo y permite saltar si es as�
        VerificarSuelo(pie, radioVerificacionSuelo);
        if (Input.GetButtonDown("Jump"))
        {
            Saltar();
        }
    }
}
