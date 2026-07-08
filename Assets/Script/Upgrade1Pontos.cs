using TMPro;
using UnityEngine;

public class Upgrade1Pontos : MonoBehaviour
{
    [SerializeField]
    float valorUpgrade = 10;
    [SerializeField]
    float aumentodeTamanho = 1f;
    [SerializeField]
    float aumentoDePreço = 2.0f;

    public TMP_Text preço;

    
    private void Start()
    {
        preço = GetComponentInChildren<TMP_Text>();
    }
    void Update()
    {
        preço.text = $"Score value: {valorUpgrade}";
    }

    public void OnUpdate1()
    {
        if (Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= (int)valorUpgrade;
            Player.scal += aumentodeTamanho;
            valorUpgrade *= aumentoDePreço;
        }
    }
}
