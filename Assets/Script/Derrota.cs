using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Derrota : MonoBehaviour
{
    public UnityEvent onDerrota;
    float tempo = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timer.timer = tempo;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Andar.scal >= 2f)
        {
            Destroy(gameObject);
        }
    }

    public void Onderrota()
    {
        if (tempo <= 0)
        {
            onDerrota.Invoke();
        }
    }

}

