using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Slider healthBar;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;

    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI winText;

    void Awake()
    {
        if (Instance != null && Instance != this) Destroy(gameObject);
        else Instance = this;
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
            scoreText.text = $"Score: {score}";
    }

    public void UpdateHealth(float health)
    {
        if (healthBar != null)
            healthBar.value = health;
    }

    public void ShowGameOver()
    {
        if (gameOverText != null)
            gameOverText.text = "GAME OVER!";
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }

    public void ShowWin(int score)
    {
        if (winText != null)
            winText.text = $"YOU WIN! Score: {score}";
        if (winPanel != null)
            winPanel.SetActive(true);
    }
}
