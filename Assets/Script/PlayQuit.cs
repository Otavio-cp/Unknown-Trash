using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quitar()
    {
        Application.Quit();
    }
}
