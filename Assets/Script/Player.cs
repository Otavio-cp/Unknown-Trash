


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
    
    private float _horizonta = 0f;
    
    private float _vertica = 0f;
    [Header("Player")]
    public static int itensPegos = 0;
    public static int itensParaAumentar;
    public static int itensNecessarios = 3;
    public static int intensganho = 1;
    public static float aumentodetamanho = 0.1f;
    public Animator playerAnim;
    public float scal = 6f;

    [SerializeField]
    private GameObject _ComerBoca;
    [Header("Camera")]
    [SerializeField] Camera _1camera;
    [SerializeField] float tamanhoAumentar = 12f;
    [SerializeField] float tamanhoAumentar2 = 25f;
    [SerializeField] float tamanhoDimi = 6f;

    [Header("Barra de vitoria")]
    [SerializeField] Slider Barradevida;
    [SerializeField] float MaximoParaGanhar = 24f;
    [SerializeField] float TamanhoBarra;



    public static bool Natelaupgrades = false;

    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.fullScreen = true;
        Barradevida.highValue = MaximoParaGanhar;
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
            if (_vertica != 0f)
            {
                playerAnim.SetBool("isWalkY", true);

            }
            else if (_vertica == 0f && _horizonta == 0f)
            {
                playerAnim.SetBool("isWalkY", false);
                playerAnim.SetBool("isWalkX", false);
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
                TamanhoBarra = transform.localScale.x;
                Barradevida.value = TamanhoBarra - 1;
                itensParaAumentar = 0;
            }

            if (transform.localScale.x >= 25f)
            {
                SceneManager.LoadScene("Vitoria");
            }

            if (transform.localScale.x >= 6f)
            {
                _1camera.orthographicSize = tamanhoAumentar;
            }
            else
            {
                _1camera.orthographicSize = tamanhoDimi;
            }

            if (transform.localScale.x >= 12f)
            {
                _1camera.orthographicSize = tamanhoAumentar2;
            }
            else if (transform.localScale.x <= 12f && transform.localScale.x >= 6f)
            {
                _1camera.orthographicSize = tamanhoAumentar;
            }
        }
        
    }
}
