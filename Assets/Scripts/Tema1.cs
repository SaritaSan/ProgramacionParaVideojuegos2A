using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Contenedor de toda la logica de nuestro objeto
public class Tema1 : MonoBehaviour
{
    //VARIABLES GLOBALES
    //Variable: Es un contenedor de informaci�n
    public int edad = 25;


    void Start()
    {
        //Variables locales
        int resultado = suma(5, 5);

        Debug.Log("El resultado es: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void walk(/* parametros */)
    {

    }

    int suma(int x ,int y)
    {
        return x + y;
    }
}
