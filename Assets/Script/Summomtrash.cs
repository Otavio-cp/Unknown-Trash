using UnityEngine;

public class Summomtrash : MonoBehaviour
{
    [SerializeField] private GameObject SpawnPrefab;
    [SerializeField] private float spawnFrequency = 2f;
    private float _timer;
    [SerializeField] private Transform Up;
    [SerializeField] private Transform Down;
    [SerializeField] private Transform Left;
    [SerializeField] private Transform Right;
    [SerializeField] private ParticleSystem particleSystemSpawn;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= spawnFrequency)
        {
            Vector2 RandomPosition = new Vector2(Random.Range(-83, 83f), Random.Range(-53, 53));
            Instantiate(SpawnPrefab, RandomPosition, Quaternion.identity);
            Instantiate(particleSystemSpawn, RandomPosition, Quaternion.identity);
            _timer = 0f;
        }

    }
}
