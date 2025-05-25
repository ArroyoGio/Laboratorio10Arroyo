using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //velocidad del movimiento del player
    public float speed = 6f;
    [SerializeField] private Disparo balas;
    [SerializeField] private int score = 0;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    //update lo llamamos una vez por cada frame
    void Update()
    {
        //movimiento horizontal, derecha e izquierda ---- A y D
        float horizontal = Input.GetAxis("Horizontal");

        //movimiento vertical, arriba y abajo ---- W y S
        float vertical = Input.GetAxis("Vertical");

        //vector que representa el movimiento del jugador en el plano XZ (no se mueve en Y)
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        //mueve al jugador multiplicando por la velocidad y por el tiempo entre frames
        transform.Translate(movement * speed * Time.deltaTime);

        //llamamos al metodo dx
        Shoop();
    }

    public void Shoop()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(balas.gameObject, transform.position, transform.rotation);
        }
    }
}
