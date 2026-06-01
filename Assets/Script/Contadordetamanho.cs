using TMPro;
using UnityEngine;

public class Contadordetamanho : MonoBehaviour
{
    public TMP_Text Contador;
    
    void Update()
    {
        Contador.text = "Score: " + Player.itensPegos;
    }
}
