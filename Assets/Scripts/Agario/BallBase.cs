using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    //Variable del nombre
    public string Name = "Ball";
    //Variable de velocidad
    public float speed = 5f;
    //Variable del area de deteccion
    public float AreaDetection = 2f;
    //Variable para almacenar la posicion del mouse
    public Vector3 MousePosition;


    /// <summary>
    /// función del movimiento
    /// </summary>
    public virtual void move()
    {
          //accedemos a la posición del mouse
        if(Input.GetMouseButtonDown(0))
        {
            //La camara se mueva en la posición del mouse
          MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //No ocupamos profundidad al ser proyecto 2D, por ende no hay z
            MousePosition.z = 0f;
        }

        //Calcular la direccion
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la dirección calculada
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
