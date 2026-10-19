using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Player2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Animator playerAnime;
    [SerializeField] float vel = 3f;
    [SerializeField] int playerHealth = 3;

    // Update is called once per frame
    void Update()
    {
        float _horizonta = Input.GetAxis("Horizontal");
        float _vertica = Input.GetAxis("Vertical");

        _rb.linearVelocity = new Vector2(_horizonta, _vertica) * vel;

        if (_horizonta != 0f)
        {
            playerAnime.SetBool("IsWalkX",  true);
        }
        if (_vertica != 0f)
        {
            playerAnime.SetBool("IsWalkY", true);

        }
        else if (_vertica == 0f && _horizonta == 0f)
        {
            playerAnime.SetBool("IsWalkY", false);
            playerAnime.SetBool("IsWalkX", false);
        }
    }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        if (playerHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("fase2");
        Debug.Log("Player morreu!");
    }

}
