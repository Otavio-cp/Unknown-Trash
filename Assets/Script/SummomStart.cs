using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SummomStart : MonoBehaviour
{
    [SerializeField] GameObject _lixo1;
    [SerializeField] GameObject _lixo2;
    [SerializeField] GameObject _lixo3;
    [SerializeField] GameObject _lixo4;
    [SerializeField] GameObject _lixo5   ;
    [SerializeField] GameObject _lixo6;
    [SerializeField] GameObject _lixo7;
    [SerializeField] GameObject _lixo8;
    [SerializeField] GameObject _lixo9;
    [SerializeField] GameObject _lixo10;
    [SerializeField] GameObject _lixo11;
    [SerializeField] GameObject _lixo12;
    [SerializeField] GameObject _lixo13;

    void Start()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-83, 83f), Random.Range(-53, 53));
        Instantiate(_lixo1, RandomPosition, Quaternion.identity);
        Instantiate(_lixo1, RandomPosition, Quaternion.identity);
        Instantiate(_lixo2, RandomPosition, Quaternion.identity);
        Instantiate(_lixo2, RandomPosition, Quaternion.identity);
        Instantiate(_lixo3, RandomPosition, Quaternion.identity);
        Instantiate(_lixo3, RandomPosition, Quaternion.identity);
        Instantiate(_lixo4, RandomPosition, Quaternion.identity);
        Instantiate(_lixo4, RandomPosition, Quaternion.identity);
        Instantiate(_lixo5, RandomPosition, Quaternion.identity);
        Instantiate(_lixo5, RandomPosition, Quaternion.identity);
        Instantiate(_lixo6, RandomPosition, Quaternion.identity);
        Instantiate(_lixo7, RandomPosition, Quaternion.identity);
        Instantiate(_lixo8, RandomPosition, Quaternion.identity);
        Instantiate(_lixo9, RandomPosition, Quaternion.identity);
        Instantiate(_lixo10, RandomPosition, Quaternion.identity);
        Instantiate(_lixo11, RandomPosition, Quaternion.identity);
        Instantiate(_lixo12, RandomPosition, Quaternion.identity);
        Instantiate(_lixo13, RandomPosition, Quaternion.identity);
        Instantiate(_lixo6, RandomPosition, Quaternion.identity);
        Instantiate(_lixo7, RandomPosition, Quaternion.identity);
        Instantiate(_lixo8, RandomPosition, Quaternion.identity);
        Instantiate(_lixo9, RandomPosition, Quaternion.identity);
        Instantiate(_lixo10, RandomPosition, Quaternion.identity);
        Instantiate(_lixo11, RandomPosition, Quaternion.identity);
        Instantiate(_lixo12, RandomPosition, Quaternion.identity);
        Instantiate(_lixo13, RandomPosition, Quaternion.identity);
    }
}
