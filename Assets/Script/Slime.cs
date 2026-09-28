using UnityEngine;
using UnityEngine.SceneManagement;

public class Slime : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trocascene"))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
