using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Espadas : EspadaBase
{

}

    //durabilidad da�o rareza
public class Madera : EspadaBase
{
    private void Start()
    {
        Durabilidad = 60f;
        Da�o = 5f;
        Rareza = "Com�n";
    }
}
public class Oro : EspadaBase
{
    private void Start()
    {
        Durabilidad = 33f;
        Da�o = 5f;
        Rareza = "Com�n";
        
    }

}
public class Diamante : EspadaBase
{
    private void Start()
    {
        
        Durabilidad = 1562f;
        Da�o = 8f;
        Rareza = "Com�n";
        
    }

}
public class Hierro : EspadaBase
{
    private void Start()
    {
        Durabilidad = 251f;
        Da�o = 7f;
        Rareza = "Com�n";
        
    }

}
public class Piedra : EspadaBase
{
    private void Start()
    {
        Durabilidad = 132f;
        Da�o = 6f;
        Rareza = "Com�n";
        
    }

}
