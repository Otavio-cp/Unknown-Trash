

using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    public static int itensPegos = 0;
    

   

    public static float scal = 1f;


    void Start()
    {
        Application.targetFrameRate = 60;
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
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move.y = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Move.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Move.x = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move.y = -1;
        }

        transform.position += Move.normalized * vel * Time.deltaTime;

        if (itensPegos >= 3)
        {
            scal += 0.1f;
            transform.localScale = new Vector3(scal, scal, scal);
            itensPegos = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        itensPegos += 1;
    }
}
