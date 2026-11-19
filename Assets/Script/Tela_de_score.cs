using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Tela_de_score : MonoBehaviour
{
    [SerializeField] LevelLoading LevelLoading;
    [SerializeField] AudioSource click;
    public void OnIrParaATelaDeUpgrade()
    {
        Time.timeScale = 1f;
        Player.Natelaupgrades = false;
        LevelLoading.Transition("Upgrade");
        click.Play();
    }
}
