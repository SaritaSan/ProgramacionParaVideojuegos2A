using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CadenaDeCaracteres : MonoBehaviour
{
    public GameObject prefab;
    public string data = "x:2, y:5, z:8";   //los strings funcionan como listas
    public Vector3 position; 


    // Start is called before the first frame update
    void Start()
    {
        //1. Recorrer tod nuestro string = "x:2, y:5, z:8"
        for (int i = 0; i < data.Length; i++) 
        {
            //2. Revisaremos si el valor en el indice (data[i]), es igual a 'x'
            if (data[i] == 'x')
            {
                //3.Si, sí es el valor, transformaremos el caracter {data[i+2]) a entero
                int x = (int)char.GetNumericValue(data[i + 2]);
                //4.Almacenamos la información de x en nuestro vector posicion
                position = new Vector3(x, position.y, position.z);
            }

            //2. Revisaremos si el valor en el indice (data[i]), es igual a 'z'
            if (data[i] == 'y')
            {
                //3.Si, sí es el valor, transformaremos el caracter {data[i+2]) a entero
                int y = (int)char.GetNumericValue(data[i + 2]);
                //4.Almacenamos la información de x en nuestro vector posicion
                position = new Vector3(position.x, y, position.z);
            }

            //2. Revisaremos si el valor en el indice (data[i]), es igual a 'x'
            if (data[i] == 'z')
            {
                //3.Si, sí es el valor, transformaremos el caracter {data[i+2]) a entero
                int z = (int)char.GetNumericValue(data[i + 2]);
                //4.Almacenamos la información de x en nuestro vector posicion
                position = new Vector3(position.x, position.y, z);
            }
        }
        FileSystem.Instance.CreateFile("Posiciones", ".save", position);
                            //         //Para que rote correctamente
        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
