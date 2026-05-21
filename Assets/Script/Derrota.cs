using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Derrota : MonoBehaviour
{
    public UnityEvent onDerrota;
    

    public void Onderrota()
    {
        if (Timer.timer <= 0f)
        {
            onDerrota.Invoke();
            
        }
    }

}

