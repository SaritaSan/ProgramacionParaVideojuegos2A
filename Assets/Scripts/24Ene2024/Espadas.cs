using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Espadas : EspadaBase
{

}

    //durabilidad daño rareza
public class Madera : EspadaBase
{
    private void Start()
    {
        Durabilidad = 60f;
        Daño = 5f;
        Rareza = "Común";
    }
}
public class Oro : EspadaBase
{
    private void Start()
    {
        Durabilidad = 33f;
        Daño = 5f;
        Rareza = "Común";
        
    }

}
public class Diamante : EspadaBase
{
    private void Start()
    {
        
        Durabilidad = 1562f;
        Daño = 8f;
        Rareza = "Común";
        
    }

}
public class Hierro : EspadaBase
{
    private void Start()
    {
        Durabilidad = 251f;
        Daño = 7f;
        Rareza = "Común";
        
    }

}
public class Piedra : EspadaBase
{
    private void Start()
    {
        Durabilidad = 132f;
        Daño = 6f;
        Rareza = "Común";
        
    }

}
