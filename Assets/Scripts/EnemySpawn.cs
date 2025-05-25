using UnityEngine;

//este script se encarga de generar (instanciar) enemigos al iniciar el juego
public class EnemySpawn : MonoBehaviour
{
    //tres posiciones donde se generarán los enemigos
    public Transform Point1;
    public Transform Point2;
    public Transform Point3;

    //tres prefabs (modelos) diferentes de enemigos
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    void Start()
    {
        // Instancia el enemigo 1 en el punto 1
        Instantiate(enemyPrefab1, Point1.position, Quaternion.identity);
        //lo mismo 2 en 2
        Instantiate(enemyPrefab2, Point2.position, Quaternion.identity);
        //lo mismo 3 en 3
        Instantiate(enemyPrefab3, Point3.position, Quaternion.identity);
    }
}
