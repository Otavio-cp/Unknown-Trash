using UnityEditor.Localization.Editor;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;

public class Andar : MonoBehaviour
{
    public int vel = 5;
    int itensPegos = 0;
    public static int tamanho = 0;

    public static float scal = 1f;
    
    
    void Start()
    {
        
    }


    void Update()
    {

        float movimentoX = Input.GetAxis("Horizontal"); // A e D
        float movimentoZ = Input.GetAxis("Vertical");   // W e S

        Vector3 movimento = new Vector3(movimentoX, 0, movimentoZ);

        transform.position += movimento * vel * Time.deltaTime;


        if (itensPegos >= 3)
        {
            scal += 0.1f;
            transform.localScale = new Vector3(scal, scal, scal);
            itensPegos = 0;
            
        }






        
    }
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        tamanho += 1;
        itensPegos += 1;
    }
}
