using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public Transform player;
    public float velocidade = 5f;

    
    private Transform camTransform;

    void Awake()
    {
        camTransform = transform;
    }

    
    void LateUpdate()
    {
        Vector3 posicaoDesejada = new Vector3(
            player.position.x,
            player.position.y,
            camTransform.position.z
        );

        camTransform.position = Vector3.Lerp(
            camTransform.position,
            posicaoDesejada,
            velocidade * Time.deltaTime
        );
    }
}
