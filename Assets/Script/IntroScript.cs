using UnityEngine;

public class IntroScript : MonoBehaviour
{
    void Start()
    {
        PlayQuit.isHistori = true;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}
