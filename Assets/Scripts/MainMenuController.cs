using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    public GameObject mainMenuScreen;
    public GameObject optionsMenuScreen;

    public void OnClickPlayButton()
    {
        mainMenuScreen.SetActive(false);
        SceneManager.LoadScene(1);

    }

    public void OnClickOptionsButton()
    {
        mainMenuScreen.SetActive(false);
        optionsMenuScreen.SetActive(true);
    }

    public void OnClickQuitMenu()
    {
        Application.Quit();
    }

    public void OnClickBackInOptionsScreen()
    {
        optionsMenuScreen.SetActive(false);
        mainMenuScreen.SetActive(true);
    }
}
