using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public static bool isHistori = false;

    public LevelLoading levelLoading;
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
        
    }
    public void Jogar2()
    {
        Timer.timer = 45 + Upgrade2Pontos.timerQNT;

        Player.Natelaupgrades = false;

        SceneManager.LoadScene("SampleScene");

        Timer.timer = 45 + Upgrade2Pontos.timerQNT;
    }
    public void Quitar()
    {
        levelLoading.Transition("start");
        Application.Quit();
    }
    public void Creditos()
    {
        levelLoading.Transition("Creditos");
    }
}
