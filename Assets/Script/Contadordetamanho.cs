using TMPro;
using UnityEngine;

public class Contadordetamanho : MonoBehaviour
{
    public TMP_Text Contador;
    void Start()
    {  
        
    }

    // Update is called once per frame
    void Update()
    {
        Contador.text = "Score: " + Andar.itensPegos;
    }
}
