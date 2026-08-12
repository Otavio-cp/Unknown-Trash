using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public static bool isHistori = false;

    public void Jogar()
    {
        if (isHistori == false)
        {
            SceneManager.LoadScene("intro");
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    public void Jogar2()
    {
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
