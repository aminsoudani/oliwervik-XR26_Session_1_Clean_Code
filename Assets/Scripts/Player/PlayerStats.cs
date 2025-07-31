using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour, IDamageable, IScorable
{
    private int score = 0;
    private float health = 30f;
    private const int winScore = 30;

    public UnityEvent onDeath;
    public UnityEvent onWin;

    private void Start()
    {
        UIManager.Instance.UpdateScore(score);
        UIManager.Instance.UpdateHealth(health);
    }

    public void AddScore(int value)
    {
        score += value;
        UIManager.Instance.UpdateScore(score);

        if (score >= winScore)
        {
            onWin?.Invoke(); // Invoking UnityEvent
            GameManager.Instance.WinGame(score);
        }
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        health = Mathf.Max(0, health);
        UIManager.Instance.UpdateHealth(health);

        if (health <= 0)
        {
            onDeath?.Invoke(); // Invoking UnityEvent
            GameManager.Instance.GameOver();
        }
    }

    public int GetScore() => score;
    public float GetHealth() => health;
}
