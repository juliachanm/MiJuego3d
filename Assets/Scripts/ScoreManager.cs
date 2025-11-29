using UnityEngine;
using TMPro; // <- importante para TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText; // <- cambia Text por TMP_Text
    private int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}
