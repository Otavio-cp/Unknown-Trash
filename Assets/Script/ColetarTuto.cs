using UnityEngine;

public class ColetarTuto : MonoBehaviour
{
    [SerializeField] Tutorial1 tutorial1;
    private void OnTriggerEnter2D(Collider2D colision)
    {
        Destroy(gameObject);
        tutorial1.liberarSala();
    }
}
