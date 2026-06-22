using UnityEngine;

public class Coletar : MonoBehaviour
{
    private bool _collected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}




