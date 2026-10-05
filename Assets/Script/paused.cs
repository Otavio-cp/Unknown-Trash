using UnityEngine;

public class paused : MonoBehaviour
{
    private bool pausado;
    [SerializeField] Canvas pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
                Continuar();
            else
                Pausar();
        }
    }

    public void Pausar()
    {
        pauseMenu.enabled = true;
        Time.timeScale = 0f;
        pausado = true;
    }

    public void Continuar()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1f;
        pausado = false;
    }
}

