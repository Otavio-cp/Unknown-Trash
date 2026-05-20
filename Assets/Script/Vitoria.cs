using UnityEngine;
using UnityEngine.Events;

public class Vitoria : MonoBehaviour
{
    public UnityEvent onVictory;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Andar.scal >= 2f)
        {
            onVictory.Invoke();
        }


    }
    public void Onvictory()
    {
        if (Timer.timer <= 0)
        {
            Destroy(gameObject);
}
    }
}
