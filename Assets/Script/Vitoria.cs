using UnityEngine;
using UnityEngine.Events;

public class Vitoria : MonoBehaviour
{
    public UnityEvent onVictory;
    float _tamanho = Andar.itensPegos;
   
    public void Onvictory()
    {
        if (_tamanho >= 10)
        {
            onVictory.Invoke();
        }
    }
}
