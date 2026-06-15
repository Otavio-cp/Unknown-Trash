using UnityEngine;

public class Summomtrash : MonoBehaviour
{
    [SerializeField] private GameObject _trash;
    [SerializeField] private GameObject _trash2;
    [SerializeField] private GameObject _trash3;

    [SerializeField] private float _summonTime;
    
    void Update()
    {
        _summonTime += Time.deltaTime;
        if (_summonTime >= 5f)
        {
            Instantiate(_trash, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(_trash2, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(_trash3, new Vector3(0, 0, 0), Quaternion.identity);
            _summonTime = 0;
        }

    }
}
