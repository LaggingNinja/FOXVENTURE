using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 4f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Player Die");
            FindObjectOfType<AudioManager>().Play("Died");
            Invoke("Restart", restartDelay);
        }

    }

    public void RestartGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Player Restart");
            Invoke("Restart", 0f);
        }

    }

    public void Back()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Player Home");
            Invoke("BackHome", 0f);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void BackHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


}
