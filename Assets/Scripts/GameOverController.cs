using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{

    public Button replayButton;
    public Button lobbyButton;

    public GameObject gameOverMenu;

    public void GameOverScreen()
    {
        gameOverMenu.SetActive(true);
    }

    public void OnClickReplayButton()
    {
        gameOverMenu.SetActive(false);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void OnClickLobbyButton()
    {
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
