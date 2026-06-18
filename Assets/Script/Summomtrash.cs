using UnityEngine;

public class Summomtrash : MonoBehaviour
{
    [SerializeField] private GameObject _trash;
    [SerializeField] private GameObject _trash2;
    [SerializeField] private GameObject _trash3;

    [SerializeField] private float _summonTime;

    
    void Spawn()
    {
        _summonTime += Time.deltaTime;

        Vector2 posicao = new Vector2(Random.Range(-87, 87), Random.Range(-53, 53));

        if (_summonTime >= 5f)
        {
            Instantiate(_trash, posicao, Quaternion.identity);
            Instantiate(_trash2, posicao, Quaternion.identity);
            Instantiate(_trash3, posicao, Quaternion.identity);
            _summonTime = 0f;
        }
    }
}
