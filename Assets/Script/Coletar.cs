using UnityEngine;

public class Coletar : MonoBehaviour
{

    
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collider2D)
    {


        Andar.scal += 0.2f;
        Destroy(gameObject);
        

    }
}




