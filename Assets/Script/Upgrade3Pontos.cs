using TMPro;
using UnityEngine;

public class Upgrade3Pontos : MonoBehaviour
{
    [SerializeField]int valorUpgrade = 30;
    [SerializeField]int colletedItensUpgrade = 1;
    
    [SerializeField]int valorMutiplicador = 2;

    [SerializeField]TMP_Text preço;
    void Start()
    {
        preço = GetComponentInChildren<TMP_Text>();
    }
    void Update()
    {
        preço.text = $"Score value: {valorUpgrade}";
    }
    public void Upgrade2()
    {
        if(Player.itensPegos >= valorUpgrade)
        {
            
            Player.itensPegos -= valorUpgrade;
            valorUpgrade *= valorMutiplicador;
            Player.itensPegos += colletedItensUpgrade;
        }
    }
}
