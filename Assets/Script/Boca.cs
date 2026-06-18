using UnityEngine;

public class Boca : MonoBehaviour
{
    [SerializeField]private float _tempoDeDESTRUIR = 0.11f;

    private void Update()
    {
        _tempoDeDESTRUIR -= Time.deltaTime;
        if (_tempoDeDESTRUIR <= 0)
        {
            Destroy(gameObject);
        }
    }

}
