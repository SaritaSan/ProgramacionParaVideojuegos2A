using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    [Header("Configuration")]

    //Lista de objetos, lista de GameObject
    public List<GameObject> Prefabs;
    //Numero de rondas
    public int RoundCount = 5;
    //tiempo entre rondas
    public float TimeBetweenRounds = 3f;
    //Área de generación
    public int SpawnArea = 5;

    [HeaderAttribute("Debug")]
    public float currentTime = 0f;
    public int currentRound = 0;

    public void Spawner()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= TimeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0f;
            currentRound++;

            if (currentRound >= RoundCount)
            {
                //Reiniciar el conteo de rondas
                currentRound = 0;

                //Ajustamos la frecuencia de generacion
                TimeBetweenRounds *= 0.9f;
            }
        }
    }

    //Posición aleatoria
    public void ObjectGeneration()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnArea, SpawnArea),
                                            Random.Range(-SpawnArea, SpawnArea),
                                            0 );
        GameObject obj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject clone = Instantiate(obj, SpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }

    //Nos va a permitir 
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(-SpawnArea, SpawnArea));
    }
}
