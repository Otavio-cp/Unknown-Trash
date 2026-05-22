using TMPro;
using UnityEngine;

public class Contadordetamanho : MonoBehaviour
{
    public TMP_Text Contador;
    void Start()
    {  
        Contador = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Contador.text = "Score: " + Andar.tamanho;
    }
}
