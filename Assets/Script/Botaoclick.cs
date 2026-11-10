using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Botaoclick : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            SceneManager.LoadScene("Main_Menu 1");
        }
    }
}
