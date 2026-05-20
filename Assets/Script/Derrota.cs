using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class Derrota : MonoBehaviour
{
    public UnityEvent onDerrota;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.timer <= 0)
        {
            onDerrota.Invoke();
        }
        if (Andar.scal >= 2f)
        {
            Destroy(gameObject);
        }
    }
}
