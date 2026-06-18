using UnityEngine;

public class Coletar : MonoBehaviour
{
    [SerializeField] private AudioClip _pickupSound;

    // Impede múltiplas coletas simultâneas
    private bool _collected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_collected)
            return;

        if (!other.CompareTag("Player"))
            return;

        _collected = true;

        if (_pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(_pickupSound, transform.position);
        }

        
        Destroy(gameObject);
    }
}




