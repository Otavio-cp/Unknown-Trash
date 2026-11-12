using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Botaoclick : MonoBehaviour
{
    [SerializeField] private TMP_Text texto;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main_Menu 1");
        }
    }

    private void OnMouseEnter()
    {
        texto.color = Color.red;
    }

    private void OnMouseExit()
    {
        texto.color = Color.white;
    }
}
