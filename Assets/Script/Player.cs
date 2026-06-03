

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
using Mono.Cecil;
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


    public Animator playerAnim;

    public static float scal = 1f;


    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.fullScreen = true;
    }
    


    void Update()
    {
        _horizonta = Input.GetAxis("Horizontal");
        _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica) * vel;

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("main_menu");
        }

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
            scal += 0.1f;
            transform.localScale = new Vector3(scal, scal, scal);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        itensPegos += 1;
    }
}
