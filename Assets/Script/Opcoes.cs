using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    [SerializeField] paused paused;
    [SerializeField] LevelLoading levelLoading;
    [SerializeField] AudioSource click;
    public void BackMenu()
    {
        if (paused != null)
        {
            print("BackMenu");
            paused.pausado = false;
            paused.pauseMenu.enabled = false;
            levelLoading.Transition("Main_Menu 1");
            Time.timeScale = 1f;
            click.Play();
        }
        else
        {
            print("BackMenu");
            levelLoading.Transition("Main_Menu 1");
            Time.timeScale = 1f;
            click.Play();
        }
    }

    public void ContinuePaused()
    {
        if (Player.Natelaupgrades == false)
        {
            paused.pausado = false;
            Time.timeScale = 1f;
            paused.pauseMenu.enabled = false;
            click.Play();
        }
    }

}
