using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOverController : MonoBehaviour
{

    public Player1Controller player1Controller;
    public Player2Controller player2Controller;

    private bool isLevelOver;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Player1Controller>() || other.gameObject.GetComponent<Player2Controller>())
        {
            Debug.Log("level over");
            SceneManager.LoadScene(2);
        }
    }

}
