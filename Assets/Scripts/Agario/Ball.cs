using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : BallBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public override void move()
    {
        //accedemos a la posición del mouse
            //La camara se mueva en la posición del mouse
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //No ocupamos profundidad al ser proyecto 2D, por ende no hay z
            MousePosition.z = 0f;

        //Calcular la direccion
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la dirección calculada
        transform.Translate(direction * speed * Time.deltaTime);

    }
}
