

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int vel = 5;

    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private float _horizonta = 0f;
    [SerializeField]
    private float _vertica = 0f;
    [SerializeField]
    private int quantidadeParaCrescer = 3;


    public Animator playerAnim;

    public static float scal = 1.5f;
    public static int itensPegos = 0;

    void Start()
    {
        Application.targetFrameRate = 30;
    }
    void Update()
    {
        _horizonta = Input.GetAxis("Horizontal");
        _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica) * vel;

        if (_horizonta!=0f)
        {
            
            playerAnim.SetBool("isWalkX", true);
        }
        else
        {
            playerAnim.SetBool("isWalkX", false);
        }


        if (_vertica!=0f)
        {
            playerAnim.SetBool("isWalkY", true);

        }
        else
        {
            playerAnim.SetBool("isWalkY", false);
        }

        if (itensPegos >= quantidadeParaCrescer)
        {
            scal += 0.2f;
            transform.localScale = new Vector3(scal, scal, scal);
            quantidadeParaCrescer += 3;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        itensPegos += 1;
    }
}
