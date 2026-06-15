using UnityEngine;
using UnityEngine.Audio;

public class Coletar : MonoBehaviour
{

    [SerializeField]
    private AudioClip pickupSound;

    [SerializeField]
    private AudioSource audioSource;

    
    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        

        if (audioSource != null)
        {
            
            audioSource.PlayOneShot(pickupSound);
            Destroy(gameObject, pickupSound.length);
        }
        else
        {
            
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
        }
    }

    
}




