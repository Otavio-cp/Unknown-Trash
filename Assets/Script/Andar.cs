using UnityEditor.Localization.Editor;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UIElements;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    int itensPegos = 0;
    

    public static float scal = 1f;
    
    
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

        if (itensPegos >= 3)
        {
            scal += 0.1f;
            transform.localScale = new Vector3(scal, scal, scal);
            itensPegos = 0;
        }


        
        


        transform.Translate(move.normalized * vel * Time.deltaTime); 
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        
        itensPegos += 1;
    }
}
