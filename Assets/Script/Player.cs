


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

    public static int itensParaAumentar;

    public static int itensNecessarios = 3;

    public static int intensganho = 1;

    public static float aumentodetamanho = 0.1f;


    public Animator playerAnim;

    public static float scal = 1f;

    [SerializeField]
    private GameObject _ComerBoca;

    private Camera1 _camera;

    public static bool Natelaupgrades = false;

    void Start()
    {
        scal = transform.localScale.x;
        Application.targetFrameRate = 60;
        Screen.fullScreen = true;
    }
    


    void Update()
    {
        if (Natelaupgrades == false)
        {
            _horizonta = Input.GetAxis("Horizontal");
            _vertica = Input.GetAxis("Vertical");

            _rb.linearVelocity = new Vector2(_horizonta, _vertica).normalized * vel;


            if (_horizonta != 0f)
            {
                playerAnim.SetBool("isWalkX", true);
            }
            else
            {
                playerAnim.SetBool("isWalkX", false);
            }


            if (_vertica != 0f)
            {
                playerAnim.SetBool("isWalkY", true);

            }
            else
            {
                playerAnim.SetBool("isWalkY", false);
            }
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
        if (Natelaupgrades == false)
        {
            itensPegos += intensganho;
            itensParaAumentar += intensganho;

            if (itensParaAumentar >= itensNecessarios)
            {
                scal += aumentodetamanho;
                transform.localScale = new Vector3(scal, scal, scal);
                itensParaAumentar = 0;
            }
            if (scal >= 25f)
            {
                SceneManager.LoadScene("Vitoria");
            }
            if (transform.localScale.x >= 6f)
            {
                Camera1.aumentarCamera = true;
            }
        }
        
    }
}
