using UnityEngine;

public class Camera : MonoBehaviour
{
    int velCamera = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
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


        if (Input.GetKey(KeyCode.UpArrow))
        {
            move.y = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move.y = -1;
        }
        







        transform.Translate(move.normalized * velCamera * Time.deltaTime);
    }
}
