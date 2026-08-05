

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    public static int itensPegos = 0;

    public static int intensganho = 1;

    public static int aumentodetamanho = 1;


    public Animator playerAnim;

    public static float scal = 1f;

    [SerializeField]
    private GameObject _ComerBoca;


    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.fullScreen = true;
    }
    


    void Update()
    {
        _horizonta = Input.GetAxis("Horizontal");
        _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica).normalized * vel;


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


        if (itensPegos >= 3)
        {
            scal += aumentodetamanho;
            transform.localScale = new Vector3(scal, scal, scal);
        }

        if (scal <= 100)
        {
            SceneManager.LoadScene("Vitoria");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        Destroy(collision2D.gameObject);
        aumentodoscore();
        Instantiate(_ComerBoca, transform.position, Quaternion.identity);
    }

    void aumentodoscore()
    {
        itensPegos += intensganho;
    }
}
