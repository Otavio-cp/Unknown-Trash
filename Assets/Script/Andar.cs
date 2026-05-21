

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    int itensPegos = 0;
    public static int tamanho = 0;

    private Rigidbody2D _rb;

    public static float scal = 1f;

    float _horizontal;
    float _vertical;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }


    void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal"); 
        float _vertical = Input.GetAxis("Vertical");   

        

        _rb.linearVelocity = new Vector2(_horizontal, _vertical) * vel;

        
        if (itensPegos >= 3)
        {
            scal += 0.1f;
            transform.localScale = new Vector3(scal, scal, scal);
            itensPegos = 0;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        tamanho += 1;
        itensPegos += 1;
    }
}
