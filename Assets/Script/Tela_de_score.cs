using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Tela_de_score : MonoBehaviour
{
    public UnityEvent onScore;
    public UnityEvent onTelaUpgrade;
    public void OnIrParaATelaDeUpgrade()
    {
        Player.Natelaupgrades = false;
        SceneManager.LoadScene("Upgrade");
    }
}
