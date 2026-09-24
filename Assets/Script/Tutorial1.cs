using UnityEngine;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField] float timer1 = 0f;
    [SerializeField] GameObject tuto1;

    void Start()
    {
        tuto1.SetActive(true);  
        timer1 += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        
    }
}
