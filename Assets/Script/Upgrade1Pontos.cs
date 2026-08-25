using TMPro;
using UnityEngine;

public class Upgrade1Pontos : MonoBehaviour
{
    [SerializeField]
    static int valorUpgrade = 10;
    [SerializeField]
    static float aumentodeTamanho2 = 0.1f;
    [SerializeField]
    static int aumentoDePreço = 2;

    [SerializeField] TMP_Text preço;

    private void Awake()
    {
        preço.text = $"Score value: {valorUpgrade}";
    }

    public void OnUpdate1()
    {
        if (Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= valorUpgrade;
            Player.aumentodetamanho += aumentodeTamanho2;
            valorUpgrade *= aumentoDePreço;
            preço.text = $"Score value: {valorUpgrade}";
        }
    }

}
