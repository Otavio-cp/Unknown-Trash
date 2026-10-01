using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField] int itensNasala;
    [SerializeField] GameObject tuto1;
    [SerializeField] GameObject tutoliberar;
    public void liberarSala()
    {
        itensNasala--;
        if (itensNasala <= 0)
        {
            tutoliberar.SetActive(false);
            tuto1.SetActive(true);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sairdotuto"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
