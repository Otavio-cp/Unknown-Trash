using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    bool isHistori = false;
    int Update2;

    public void Jogar()
    {
        if (isHistori == false)
        {
            SceneManager.LoadScene("Hist�ria");
            isHistori = true;
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    public void Jogar2()
    {
        SceneManager.LoadScene("SampleScene");
        // apply saved timer bonus
        Timer.timer = 60 + Upgrade2Pontos.timerQNT;
        // ensure no accidental use of =+ operator
        Upgrade2Pontos.timerQNT = Upgrade2Pontos.timer;
    }
    public void Quitar()
    {
        Application.Quit();
    }
}
