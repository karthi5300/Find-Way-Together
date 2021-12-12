using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameOverController gameOverController;

    public float timeRemaining = 100;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            gameOverController.GameOverScreen();
        }

        DisplayTime(timeRemaining);
    }


    public void DisplayTime(float timeRemaining)
    {
        timerText.text = "Time: " + (int)timeRemaining;
    }

    public void StopTimer()
    {
        int levelScore = (int)timeRemaining;
        PlayerPrefs.SetInt("levelScore", levelScore);
    }
}
