using UnityEngine;
using UnityEngine.SceneManagement;

public class partefinal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Victory");
    }
}
