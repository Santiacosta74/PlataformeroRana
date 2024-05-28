using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJugador : MonoBehaviour
{
    MovimientoJugador movimiento;
    AnimacionesJugador animaciones;

    private void Start()
    {
        movimiento = GetComponent<MovimientoJugador>();
        animaciones = GetComponent<AnimacionesJugador>();
        movimiento.enabled = true;
    }

    public void RecibirDaño()
    {
        animaciones.Daño();
        movimiento.enabled = false;
    }
}
