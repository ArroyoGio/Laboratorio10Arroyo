using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private PlayerMovement jugador;
    void Start()
    {
        jugador = FindObjectOfType<PlayerMovement>();
    }
    void Update()
    {
        ScoreUpdate();
    }
    private void ScoreUpdate()
    {
        score.text = "Score: " + jugador.Score;
    }
}
