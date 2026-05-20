using TMPro;
using UnityEngine;

public class Contadordetamanho : MonoBehaviour
{
    public TMP_Text Contador;
    private int tamanhoContador = 0;
    void Start()
    {
        
        Contador = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        tamanhoContador = Andar.tamanho;
        Contador.text = tamanhoContador.ToString("N0");

    }
}
