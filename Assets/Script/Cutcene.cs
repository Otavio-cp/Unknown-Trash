using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Cutcene : MonoBehaviour
{
    [SerializeField] PlayableDirector timeline;

    void OnEnable()
    {
        timeline.stopped += TerminouTimeline;
    }

    void OnDisable()
    {
        timeline.stopped -= TerminouTimeline;
    }

    void TerminouTimeline(PlayableDirector director)
    {
        SceneManager.LoadScene("Vitory");
    }
}
