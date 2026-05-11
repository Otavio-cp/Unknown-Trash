using UnityEngine;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    
    void Start()
    {

    }


    void Update()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            move.y = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.y = -1;
        }






        
        
        transform.Translate(move.normalized * vel * Time.deltaTime); 
    }
}
