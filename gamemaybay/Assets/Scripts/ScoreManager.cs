using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TMP_Text scoreText;

    public GameObject winPanel;
    public TMP_Text winText;

    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
        UpdateScore();

        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScore();

        if (score >= 100)
        {
            WinGame();
        }
    }

    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    void WinGame()
    {
        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }

        if (winText != null)
        {
            winText.text = "YOU WIN!";
        }

        Time.timeScale = 0f;
    }
}