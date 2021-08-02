using UnityEngine;
using UnityEngine.SceneManagement;


public class GameButton : MonoBehaviour
{
    bool isPause = false;
    public void ReloadGame()
    {
      Application.LoadLevel(Application.loadedLevel);
      Time.timeScale = 1;
      isPause = false;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PauseGame()
    {
       
        if (isPause) {
            Time.timeScale = 1;
            isPause = false;
        }
        else {
            Time.timeScale = 0;
            isPause = true;
        }
    }
}
