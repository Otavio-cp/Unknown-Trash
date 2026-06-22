using UnityEngine;

public class Summomtrash : MonoBehaviour
{
    [SerializeField] private GameObject _trash;

    [Min(2.5f)][SerializeField] private float _summonTime;
    [SerializeField] private float _summonTimeReset = 0;


    public void Spawn()
    {
        _summonTime -= Time.deltaTime;

        Vector2 posicao = new Vector2(Random.Range(-87, 87), Random.Range(-53, 53));

        if (_summonTime >= _summonTimeReset)
        {
            Instantiate(_trash, posicao, Quaternion.identity);
            _summonTime = 1;
        }
    }
}
