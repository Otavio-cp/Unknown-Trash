using UnityEngine;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField] float timer1 = 0f;
    [SerializeField] GameObject tuto1;
    [SerializeField] GameObject tutoliberar;
    public static bool terminou = false;


    private void FixedUpdate()
    {
        if (terminou == false)
        {
            if (timer1 >= 5f)
            {
                tuto1.SetActive(false);
                terminou = true;
            }
            else
            {
                timer1 += Time.deltaTime;
            }
        }
    }
    public void liberarSala(int itensNaSala)
    {
        if (itensNaSala == 0)
        {
            tuto1.SetActive(false);
            tutoliberar.SetActive(true);
        }
    }
}
