using UnityEngine;
using UnityEngine.Events;

public class BottomMenu : MonoBehaviour
{
    public UnityEvent onMainMenuClose;
    public UnityEvent onMainMenuOpen;
    public UnityEvent onMenuOpen;
    public UnityEvent onMenuClose;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            onMainMenuOpen.Invoke();
        }
        else
        {
            onMainMenuClose.Invoke();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            onMenuOpen.Invoke();
        }
        else
        {
            onMenuClose.Invoke();
        }
    }

    public void MainMenu()
    {
        onMainMenuClose.Invoke();
    }
}
