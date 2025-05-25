using UnityEngine;

public class SpawnerLoop : MonoBehaviour
{
    public GameObject[] enemyPrefabs;     // Arreglo con tus prefabs (enemigo1, 2 y 3)
    public Transform[] spawnPoints;       // Arreglo con los puntos (Point1, 2 y 3)
    public float spawnInterval = 5f;      // Cada cuántos segundos se genera un enemigo

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, spawnInterval); // Comienza a generar enemigos
    }

    void SpawnEnemy()
    {
        // Escoge un punto y un prefab aleatoriamente
        int randomPoint = Random.Range(0, spawnPoints.Length);
        int randomEnemy = Random.Range(0, enemyPrefabs.Length);

        // Instancia el enemigo en el punto elegido
        Instantiate(enemyPrefabs[randomEnemy], spawnPoints[randomPoint].position, Quaternion.identity);
    }
}
