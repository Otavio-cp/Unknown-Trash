using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    [SerializeField] GameObject tuto2;
    public static bool terminou = false;
    void FixedUpdate()
    {
        if (terminou == true)
        {
            tuto2.SetActive(false);
        }
        
    }
}
