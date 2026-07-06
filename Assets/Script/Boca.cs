using UnityEngine;

public class Boca : MonoBehaviour
{
    [SerializeField] private float _tempoDeDESTRUIR = 0.11f;
    [SerializeField] private AudioClip _ComerAudio;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private ParticleSystem _particleSystem;


    private void Start()
    {
        if (_audioSource != null && _ComerAudio != null)
        {
            _audioSource.PlayOneShot(_ComerAudio);
        }
    }
    private void Update()
    {
        _tempoDeDESTRUIR -= Time.deltaTime;
        if (_tempoDeDESTRUIR <= 0)
        {
            Destroy(gameObject);
        }

    }

}
