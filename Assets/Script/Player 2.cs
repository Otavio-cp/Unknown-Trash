using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Player2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Animator playerAnime;
    [SerializeField] float vel = 3f;
    public SpriteRenderer playerSprite;
    [SerializeField]
    float _vertica;
    [SerializeField]
    float _horizonta;

    // Update is called once per frame
    void Update()
    {
        _horizonta = Input.GetAxis("Horizontal");
        _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica) * vel;

        // Virar sprite
        if (_horizonta > 0)
        {
            playerSprite.flipX = false;
        }
        else if (_horizonta < 0)
        {
            playerSprite.flipX = true;
        }

        // Animação
        if (_horizonta != 0 || _vertica != 0)
        {
            playerAnime.SetBool("ANDAR", true);
        }
        else
        {
            playerAnime.SetBool("ANDAR", false);
        }
    }

}
