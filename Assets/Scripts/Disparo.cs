using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float speed = 10f;
    [SerializeField] private PlayerMovement Player;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void Start()
    {
        Player = FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Player.Score++;
            Debug.Log("Score: " + Player.Score);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
