using UnityEngine;
using UnityEngine.Audio;

public class Coletar : MonoBehaviour
{
    public AudioSource Comer;

    [SerializeField] private string targetTag = "lixo"; 

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        
        if (other.CompareTag(targetTag))
        {
            // Play the audio if it is not already playing
            if (!Comer.isPlaying)
            {
                Comer.Play();
            }

        }
    }

}




