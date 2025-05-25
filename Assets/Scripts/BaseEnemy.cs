using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public Transform player;  //Referencia al jugador (para saber d�nde est�)
    public float speed = 3f; //Velocidad a la que el enemigo se mueve
    public bool followPlayer = false;  // Si est� en true, el enemigo sigue al jugador
    public bool fleePlayer = false;   //Si est� en true, el enemigo huye del jugador
    
    void Update()
    {
        if (player == null)
        { 
            return;  //Si no hay jugador asignado, no hace nada
        }

        //Calcula la direcci�n desde el enemigo hacia el jugador
        Vector3 dir = player.position - transform.position;

        if (followPlayer)
        {
            //El enemigo se mueve hacia el jugador (lo sigue)
            transform.position += dir.normalized * speed * Time.deltaTime;
        } 

        if (fleePlayer)
        {
            //El enemigo se aleja del jugador (huye)
            transform.position -= dir.normalized * speed * Time.deltaTime;
        }
    }
}
