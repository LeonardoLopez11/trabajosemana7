using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador : MonoBehaviour , istats
{
    public int Fuerza { get; set; }
    public int Destreza { get; set; }
    public int Vida { get; set; }
    public string Nombre { get; set; }
    public void AsignarAtributos(int fuerza, int destreza, int vida)
    {
        if (fuerza + destreza + vida <= 100)
        {
            Fuerza = fuerza;
            Destreza = destreza;
            Vida = vida;
        }
        else
        {
            Debug.LogError("No puede ser más que 100");
        }
    }
}
