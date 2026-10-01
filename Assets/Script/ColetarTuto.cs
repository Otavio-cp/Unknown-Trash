using UnityEngine;

public class ColetarTuto : MonoBehaviour
{
    [SerializeField] int itensNaSala;
    [SerializeField] GameObject sala;
    [SerializeField] GameObject salaTuto;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        itensNaSala -= 1;
        other.gameObject.GetComponent<Tutorial1>().liberarSala(itensNaSala);
    }
}
