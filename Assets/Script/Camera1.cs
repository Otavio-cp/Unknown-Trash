using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera1 : MonoBehaviour
{
    [SerializeField] Camera _1camera;
    [SerializeField] float tempo;
    [SerializeField] float tamanhoAumentar = 12f;
    [SerializeField] float tamanhoAumentar2 = 12f;
    [SerializeField] float tamanhoDimi = 6f;
    [SerializeField] float duracao = 2f;
    public static bool aumentarCamera = false;
    public static bool aumentarCamera2 = false;


    private void Update()
    {
        if (aumentarCamera == true)
        {
            AumentarCamera();
        }
        else
        {
            DiminuirCamera();
        }
        if (aumentarCamera2 == true)
        {
            AumentarCamera2();
        }
        else if (aumentarCamera == true)
        {
            AumentarCamera();
        }
    }


    public void AumentarCamera()
    {
        _1camera.orthographicSize = Mathf.Lerp(_1camera.orthographicSize, tamanhoAumentar, tempo / duracao);
    }
    public void AumentarCamera2()
    {
        _1camera.orthographicSize = Mathf.Lerp(_1camera.orthographicSize, tamanhoAumentar2, tempo / duracao);
    }
    public void DiminuirCamera()
    {

        _1camera.orthographicSize = Mathf.Lerp(_1camera.orthographicSize, tamanhoDimi, tempo / duracao);
    }
}
