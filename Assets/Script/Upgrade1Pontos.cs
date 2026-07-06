using TMPro;
using UnityEngine;

public class Upgrade1Pontos : MonoBehaviour
{
    [SerializeField]
    float valorUpgrade = 10;
    [SerializeField]
    int aumentodeTamanho = 2;
    [SerializeField]
    float aumentoDePreço = 2f;

    public TMP_Text preço;

    
    private void Start()
    {
        preço = GetComponentInChildren<TMP_Text>();
        preço.text = $"Upgrade Tamanho: {valorUpgrade}";
    }

    public void OnUpdate1()
    {
        if (Player.itensPegos <= valorUpgrade)
        {
            Player.scal += aumentodeTamanho;
            valorUpgrade *= aumentoDePreço;
        }
    }
}
