using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    [SerializeField]
    private float scaleFactor = 0.8f;
    [SerializeField]
    private bool isMouseExit = true;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }
    private void OnMouseExit()
    {
        isMouseExit = true;
        transform.localScale = originalScale;
    }

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Quitar()
    {
        Application.Quit();
    }

    private void OnMouseEnter()
    {
        isMouseExit = false;
        if (isMouseExit)
        {
            transform.localScale = originalScale * scaleFactor;
        }
    }
}
