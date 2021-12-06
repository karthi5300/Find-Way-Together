using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameOverController gameOverController;

    public float timeRemaining = 100;

    void Start()
    {

    }

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

        Debug.Log("time remaining = " + timeRemaining);

        DisplayTime(timeRemaining);
    }


    public void DisplayTime(float timeRemaining)
    {
        timerText.text = "Time: " + (int)timeRemaining;
    }

}
