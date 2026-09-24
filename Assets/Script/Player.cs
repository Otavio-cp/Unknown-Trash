


using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEditor.Experimental.GraphView;
using JetBrains.Annotations;

public class Player : MonoBehaviour
{
    [SerializeField] private int vel = 5;
    [SerializeField] private Rigidbody2D _rb;
    private float _horizonta = 0f;
    private float _vertica = 0f;
    public static int itensPegos = 0;
    public static int itensParaAumentar;
    public static int itensNecessarios = 3;
    public static int intensganho = 1;
    public static float aumentodetamanho = 0.1f;
    public static bool Natelaupgrades = false;

    [Header("Player")]
    public Animator playerAnim;
    [SerializeField] float scal = 1f;
    [SerializeField]
    private GameObject _ComerBoca;
    [SerializeField] ParticleSystem particolEND;

    [Header("Barra de Vitoria")]
    [SerializeField] private Slider _barraDeVitoria;
    private int _barraDeVitoriaMax = 24;
    private float _vitoryBarra;

    [Header("Camera")]
    [SerializeField] Camera _1camera;
    [SerializeField] float tamanhoAumentar = 12f;
    [SerializeField] float tamanhoAumentar2 = 25f;
    [SerializeField] float tamanhoDimi = 6f;

    public Transform player;
   
    void Start()
    {
        Application.targetFrameRate = 30;
        Screen.fullScreen = true;
        _barraDeVitoria.maxValue = _barraDeVitoriaMax;
    }
    


    void Update()
    {
        if (Natelaupgrades == false)
        {
            CameraFollow();
            _horizonta = Input.GetAxis("Horizontal");
            _vertica = Input.GetAxis("Vertical");

            _rb.linearVelocity = new Vector2(_horizonta, _vertica).normalized * vel;

            if (_horizonta != 0f)
            {
                playerAnim.SetBool("IsWalkX", true);
            }
            if (_vertica != 0f)
            {
                playerAnim.SetBool("IsWalkY", true);

            }
            else if (_vertica == 0f && _horizonta == 0f)
            {
                playerAnim.SetBool("IsWalkY", false);
                playerAnim.SetBool("IsWalkX", false);
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

                transform.localScale = new Vector3(scal, scal, 1f);

                _vitoryBarra = transform.localScale.x;
                _barraDeVitoria.value = _vitoryBarra - 1;
                itensParaAumentar = 0;
            }

            
            if (transform.localScale.x >= 25f)
            {
                SceneManager.LoadScene("Vitoria");
                Instantiate(particolEND, transform.position, Quaternion.identity);
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

    public void CameraFollow()
    {   Vector3 cameraPosition = new Vector3(player.position.x, player.position.y, -10f);
        _1camera.transform.position = cameraPosition;
        Vector3.Lerp (_1camera.transform.position, cameraPosition, Time.deltaTime * 5f);
    }
}
