using TMPro;
using UnityEngine;

public class Upgrade1Pontos : MonoBehaviour
{
    [SerializeField]
    static float valorUpgrade = 10;
    [SerializeField]
    static float aumentodeTamanho = 1f;
    [SerializeField]
    static float aumentoDePreço = 2.0f;

    [SerializeField] TMP_Text preço;
    public void OnUpdate1()
    {
        if (Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= (int)valorUpgrade;
            Player.scal += aumentodeTamanho;
            valorUpgrade *= aumentoDePreço;
            preço.text = $"Score value: {valorUpgrade}";
        }
    }

}
