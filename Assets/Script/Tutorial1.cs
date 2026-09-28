using UnityEngine;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField] float timer1 = 0f;
    [SerializeField] GameObject tuto1;
    public static bool terminou = false;

    void Start()
    {
        tuto1.SetActive(true);
    }

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
}
