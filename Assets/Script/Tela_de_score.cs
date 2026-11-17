using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Tela_de_score : MonoBehaviour
{
    public UnityEvent onScore;
    public UnityEvent onTelaUpgrade;
    [SerializeField] LevelLoading LevelLoading;
    public void OnIrParaATelaDeUpgrade()
    {
        Time.timeScale = 1f;
        Player.Natelaupgrades = false;
        LevelLoading.Transition("Upgrade");
    }
}
