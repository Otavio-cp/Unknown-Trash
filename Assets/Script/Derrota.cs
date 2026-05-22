using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Derrota : MonoBehaviour
{
    public UnityEvent onderrota;
    public void Onderrota()
    {
        if (Timer.timer <= 0f)
        {
            onderrota.Invoke();

        }
    }
}

