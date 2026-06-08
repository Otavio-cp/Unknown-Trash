using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opcoes : MonoBehaviour
{
    public void BackMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
