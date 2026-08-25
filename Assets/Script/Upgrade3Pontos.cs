using TMPro;
using UnityEngine;

public class Upgrade3Pontos : MonoBehaviour
{
    [SerializeField]static int valorUpgrade = 40;
    [SerializeField]static int aumentodeitens = 1;
    
    [SerializeField]static int valorMutiplicador = 2;

    [SerializeField]TMP_Text preço;
    private void Awake()
    {
        preço.text = $"Score value: {valorUpgrade}";
    }
    public void Upgrade2()
    {
        if(Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= valorUpgrade;
            valorUpgrade *= valorMutiplicador;
            Player.intensganho += aumentodeitens;
            preço.text = $"Score value: {valorUpgrade}";
        }
    }
}
