using TMPro;
using UnityEngine;

public class Upgrade3Pontos : MonoBehaviour
{
    [SerializeField]static int valorUpgrade = 30;
    [SerializeField]static int colletedItensUpgrade = 1;
    
    [SerializeField]static int valorMutiplicador = 2;

    [SerializeField]TMP_Text preço;
    void Start()
    {
        preço = GetComponentInChildren<TMP_Text>();
    }
    public void Upgrade2()
    {
        if(Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= valorUpgrade;
            valorUpgrade *= valorMutiplicador;
            Player.itensPegos += colletedItensUpgrade;
            preço.text = $"Score value: {valorUpgrade}";
        }
    }
}
