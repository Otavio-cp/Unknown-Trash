using UnityEngine;

public class BordadoMapa : MonoBehaviour
{
    private Vector2 startPos;
    public Vector2 targetPos;
    public float speed = 5f;
    private bool voltando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 destinoAtual = voltando ? startPos : targetPos;


        transform.position = Vector2.MoveTowards(transform.position, destinoAtual, speed * Time.deltaTime);


        if ((Vector2)transform.position == destinoAtual)
        {
            voltando = !voltando;
        }
    }
}
