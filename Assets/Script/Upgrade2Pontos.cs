using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;

public class Upgrade2Pontos : MonoBehaviour
{
    static int valorUpgrade = 20;
    public static float timerQNT = 0;

    [SerializeField] int multiplicador = 2;

    [SerializeField] TMP_Text preço;
    private void Awake()
    {
        preço.text = $"Score value: {valorUpgrade}";
    }
    public void Update2()
    {
        if(Player.itensPegos >= valorUpgrade)
        {
            Player.itensPegos -= valorUpgrade;
            valorUpgrade *= multiplicador;
            timerQNT += 10f;
            preço.text = $"Score value: {valorUpgrade}";
        }
    }
}
