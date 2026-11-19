using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public static bool isHistori = false;

    public LevelLoading levelLoading;
    [SerializeField] AudioSource click;
    public void Jogar()
    {
        if (isHistori == false)
        {
            levelLoading.Transition("cutscene");
            isHistori = true;
        }
        else
        {
            levelLoading.Transition("SampleScene");
        }
        click.Play();

    }
    public void Jogar2()
    {
        Timer.timer = 45 + Upgrade2Pontos.timerQNT;

        Player.Natelaupgrades = false;

        levelLoading.Transition("SampleScene");

        Timer.timer = 45 + Upgrade2Pontos.timerQNT;
        click.Play();
    }
    public void Quitar()
    {
        levelLoading.Transition("start");
        Application.Quit();
        click.Play();
    }
    public void Creditos()
    {
        levelLoading.Transition("Creditos");
        click.Play();
    }
}
