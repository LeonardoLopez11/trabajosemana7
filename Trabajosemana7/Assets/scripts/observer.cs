using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observer : MonoBehaviour
{
    private jugador jugador;
    


    // Start is called before the first frame update
    void Start()
    {
        jugador = jugadormanager.ObtenerJugador(); 
        jugador.JugadorCreado += ReaccionJugadorCreado; 
    }

    private void ReaccionJugadorCreado()
    {
        Debug.Log("Jugador creado.");
    }
    void Update()
    {
        
    }
}
