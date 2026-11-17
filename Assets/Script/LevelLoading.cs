using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    [SerializeField] Animator transitionAnimator;
    public void Transition(string sceneName)
    {
        StartCoroutine(LoadSceneTransition(sceneName));

    }

    IEnumerator LoadSceneTransition(string sceneName)
    {
        transitionAnimator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }

}
