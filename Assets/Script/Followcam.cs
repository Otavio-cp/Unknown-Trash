using UnityEngine;

public class Followcam : MonoBehaviour
{

    [SerializeField] GameObject Player;
    
    void Update()
    {
        Vector3 cameraPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, -10f);
        transform.position = cameraPosition;
        Vector3.Lerp(transform.position, cameraPosition, Time.deltaTime * 5f);
    }
}
