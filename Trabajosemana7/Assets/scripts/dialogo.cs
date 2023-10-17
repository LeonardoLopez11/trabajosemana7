using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialogo 
{
    public string Texto { get; set; }
    public List<Opcion> Opciones { get; set; }
    
}
public class Opcion
{
    public string Texto { get; set; }
    public int MinimoFuerza { get; set; }
    public int MinimoDestreza { get; set; }
    public int PerderVida { get; set; }
    public List<dialogo> SiguienteDialogo { get; set; }
}
