using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public int totalScore = 0;
    public int levelScore = 0;
    public TextMeshProUGUI levelScoreText;

    // Singleton instance.
    public static ScoreManager Instance = null;

    // Initialize the singleton instance.
    private void Awake()
    {
        // If there is not already an instance of SoundManager, set it to this.
        if (Instance == null)
        {
            Instance = this;
        }
        //If an instance already exists, destroy whatever this object is, to enforce the singleton.
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("totalScore");
        Debug.Log("total score : " + totalScore);
        levelScoreText.text = "Total Score : " + totalScore;
    }

    public void CalculateLevelScore()
    {
        levelScore = PlayerPrefs.GetInt("levelScore");
        UpdateTotalScore(levelScore);

        Debug.Log("level score : " + levelScore);
        Debug.Log("total score : " + totalScore);
    }

    public void UpdateTotalScore(int score)
    {
        totalScore += score;
    }

    public int GetLevelScore()
    {
        return levelScore;
    }

    public int GetTotalScore()
    {
        return totalScore;
    }




}