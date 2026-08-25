using UnityEngine;

public class Coletar : MonoBehaviour
{
    private bool _collected;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
    private void Start()
    {
        Mudar();
    }

    public void Mudar()
    {
        float randomRotate = Random.Range(0f, 360f);
        transform.rotation = Quaternion.Euler(0f, 0f, randomRotate);
    }
}




