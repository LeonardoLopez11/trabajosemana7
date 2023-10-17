using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadormanager : MonoBehaviour
{
    private static jugador _jugador;

    public static jugador ObtenerJugador()
    {
        if (_jugador == null)
        {
            _jugador = new jugador();
        }
        return _jugador;
    }
}
