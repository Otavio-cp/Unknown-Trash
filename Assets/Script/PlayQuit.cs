using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    int Update2;
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
        Timer.timer = 60f + Update2;
    }
    public void Quitar()
    {
        Application.Quit();
    }
}
