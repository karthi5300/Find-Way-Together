using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{

    public GameObject mainMenuScreen;
    public GameObject optionsMenuScreen;
    public TextMeshProUGUI resetMessage;
    public AudioClip lobbyMusic;
    public AudioClip buttonPressSound;
    public AudioClip gameMusic;

    void Start()
    {
        PlayerPrefs.SetInt("totalScore", 0);
        int sceneIndex = GetSceneIndex();
        if (sceneIndex == 0)
            SoundManager.Instance.PlayMusic(lobbyMusic);
        else
            SoundManager.Instance.PlayMusic(gameMusic);
    }

    public void OnClickPlayButton()
    {
        SoundManager.Instance.Play(buttonPressSound);
        mainMenuScreen.SetActive(false);
        SceneManager.LoadScene(1);
    }

    public void OnClickOptionsButton()
    {
        SoundManager.Instance.Play(buttonPressSound);
        mainMenuScreen.SetActive(false);
        optionsMenuScreen.SetActive(true);
    }

    public void OnClickQuitMenu()
    {
        SoundManager.Instance.Play(buttonPressSound);
        Application.Quit();
    }

    public void OnClickBackInOptionsScreen()
    {
        SoundManager.Instance.Play(buttonPressSound);
        optionsMenuScreen.SetActive(false);
        resetMessage.gameObject.SetActive(false);
        mainMenuScreen.SetActive(true);
    }

    public void OnClickResetButton()
    {
        SoundManager.Instance.Play(buttonPressSound);
        resetMessage.gameObject.SetActive(true);
        PlayerPrefs.DeleteAll();
    }

    public int GetSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex; ;
    }

}
