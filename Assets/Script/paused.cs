using UnityEngine;

public class paused : MonoBehaviour
{
    public bool pausado;
    public Canvas pauseMenu;


    void Start()
    {
        pausado = false;
        pauseMenu.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Player.Natelaupgrades == false)
            {
                if (pausado)
                    Continuar();
                else
                    Pausar();
            }
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

