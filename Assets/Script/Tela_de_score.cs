using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Tela_de_score : MonoBehaviour
{
    public UnityEvent onScore;
    public UnityEvent onTelaUpgrade;
    public GameObject telamorte;
    void Update()
    {
        if (Timer.timer <= 0)
        {
            onScore.Invoke();
        }
    }
    public void OnIrParaATelaDeUpgrade()
    {
        SceneManager.LoadScene("Upgrade");
    }

    public void voltar()
    {

        


    }
}
