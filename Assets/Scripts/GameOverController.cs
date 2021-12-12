using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public Button replayButton;
    public Button lobbyButton;

    public GameObject gameOverScreen;

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void OnClickReplayButton()
    {
        gameOverScreen.SetActive(false);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void OnClickLobbyButton()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
