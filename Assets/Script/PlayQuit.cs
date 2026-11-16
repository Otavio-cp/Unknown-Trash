using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public static bool isHistori = false;

    [SerializeField] LevelLoading levelLoading;
    public string sceneNameStart;
    public string sceneNameGame;
    public void Jogar()
    {
        if (isHistori == false)
        {
            levelLoading.Transition(sceneNameStart);
            isHistori = true;
        }
        else
        {
            levelLoading.Transition(sceneNameGame);
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
        Application.Quit();
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}
