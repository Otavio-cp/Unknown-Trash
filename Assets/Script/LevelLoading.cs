using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    [SerializeField] Animator transitionAnimator;

    public void Transition(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));

    }

    IEnumerator LoadScene(string sceneName)
    {
        transitionAnimator.SetTrigger("Startcdsuhfdsfj09uy583w hiru8yzdwh fn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

}
