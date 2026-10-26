using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    [SerializeField] paused paused;
    public void BackMenu()
    {
        paused.pausado = false;
        paused.pauseMenu.enabled = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main_Menu 1");
    }

    public void ContinuePaused()
    {
        if (Player.Natelaupgrades == false)
        {
            paused.pausado = false;
            Time.timeScale = 1f;
            paused.pauseMenu.enabled = false;
        }
    }
}
