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

        if (Timer.timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Onvictory()
    {
        

        if (Andar.scal >= 2f)
        {
            onVictory.Invoke();
        }
    }
}
