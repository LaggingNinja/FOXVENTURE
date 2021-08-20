using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    
    public void StartGame()
    {
        Invoke("LaunchProjectile", 3.0f);
    }

    void LaunchProjectile()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
