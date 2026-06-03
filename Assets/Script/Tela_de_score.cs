using UnityEngine;
using UnityEngine.Events;

public class Tela_de_score : MonoBehaviour
{
    public UnityEvent onScore;
    public UnityEvent onTelaUpgrade;    
    void Update()
    {
        if (Timer.timer <= 0)
        {
            onScore.Invoke();
        }
    }

    public void OnIrParaATelaDeUpgrade()
    {
        onTelaUpgrade.Invoke();
    }
}
