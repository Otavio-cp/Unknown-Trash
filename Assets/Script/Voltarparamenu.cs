
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltarparamenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
