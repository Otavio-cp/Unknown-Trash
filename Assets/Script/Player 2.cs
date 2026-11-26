using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Player2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Animator playerAnime;
    [SerializeField] float vel = 3f;
    public SpriteRenderer playerSprite;
    [SerializeField] float TimerforEfects;
    [SerializeField] GameObject particulas;
    [SerializeField] ParticleSystem playerParticle;
    [SerializeField]
    float _vertica;
    [SerializeField]
    float _horizonta;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        playerAnime = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
        playerParticle = GetComponent<ParticleSystem>();
        playerParticle = particulas.GetComponent<ParticleSystem>();
        playerParticle.Stop();
    }
    void Update()
    {
        _horizonta = Input.GetAxis("Horizontal");
        _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica) * vel;
        if (_horizonta > 0)
        {
            playerSprite.flipX = false;
        }
        else if (_horizonta < 0)
        {
            playerSprite.flipX = true;
        }
        if (_horizonta != 0 || _vertica != 0)
        {
            playerAnime.SetBool("ANDAR", true);
            playerParticle.Stop();
            TimerforEfects = 0f;
        }
        else
        {
            playerAnime.SetBool("ANDAR", false);
        }
        if (_horizonta == 0 || _vertica == 0)
        {
            TimerforEfects += Time.deltaTime;
            if (TimerforEfects >= 0.5f)
            {
                playerParticle.Play();
            }
        }
    }
}
