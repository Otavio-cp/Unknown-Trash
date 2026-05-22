using UnityEngine;

public class Coletar : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Destroy(gameObject);
    }
}




