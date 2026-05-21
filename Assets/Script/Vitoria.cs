using UnityEngine;
using UnityEngine.Events;

public class Vitoria : MonoBehaviour
{
    public UnityEvent onVictory;
    
    public void Onvictory()
    {
        

        if (Andar.scal >= 2f)
        {
            onVictory?.Invoke();
        }
    }
}
