using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class LevelOverController : MonoBehaviour
{
    public Player1Controller player1Controller;
    public Player2Controller player2Controller;
    public TimeController timeController;

    public GameObject levelOverScreen;
    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI levelScoreText;
    public TextMeshProUGUI loadingText;

    private bool isPlayer1Finished;
    private bool isPlayer2Finished;
    private bool isLevelOver;

    private float loadingTextDelay = 0.75f;
    private float loadingDot = 3f;
    string loadString = "Loading Next Level";

    void Start()
    {
        isPlayer1Finished = false;
        isPlayer2Finished = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player1Controller>())
            isPlayer1Finished = true;

        if (other.GetComponent<Player2Controller>())
            isPlayer2Finished = true;

        IsLevelOver();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Player1Controller>())
            isPlayer1Finished = false;

        if (other.GetComponent<Player2Controller>())
            isPlayer2Finished = false;
    }

    public void IsLevelOver()
    {
        RefreshUI();

        if (isPlayer1Finished && isPlayer2Finished)
        {
            timeController.StopTimer(); //if both player reaches finish, stop the timer

            levelOverScreen.SetActive(true); //load level over screen
            StartCoroutine("Loading");
        }
    }

    public void RefreshUI()
    {
        ScoreManager.Instance.CalculateLevelScore();

        totalScoreText.text = "Total Score : " + ScoreManager.Instance.GetTotalScore();
        levelScoreText.text = "Level Score : " + ScoreManager.Instance.GetLevelScore();
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2f);

        for (int i = 0; i <= loadingDot; i++)
        {
            loadingText.text = loadString;
            loadString += ".";
            yield return new WaitForSeconds(loadingTextDelay);
        }

        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        levelOverScreen.SetActive(false);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }

}
