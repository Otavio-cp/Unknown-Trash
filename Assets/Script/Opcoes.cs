using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    [SerializeField] paused paused;
    [SerializeField] LevelLoading levelLoading;
    [SerializeField] AudioSource click;
    public void BackMenu()
    {
        print("BackMenu");
        paused.pausado = false;
        paused.pauseMenu.enabled = false;
        Time.timeScale = 1f;

        levelLoading.Transition("Main_Menu 1");
        click.Play();
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
