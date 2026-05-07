using UnityEngine;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    void Start()
    {

    }


    void Update()
    {
        Vector3 Move = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Move.y = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Move.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move.y = -1;
        }







        transform.position += Move.normalized * vel * Time.deltaTime;
    }
}
