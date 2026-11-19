using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Cutcene : MonoBehaviour
{
    [SerializeField] PlayableDirector timeline;
    [SerializeField] float timeTotimeline = 8.566f;  // EU amo o FAKER do League Of Legends >:3
    [SerializeField] Player player;
    [SerializeField] LevelLoading level;
    [SerializeField] Canvas canvas1Hub;

    private void Start()
    {
        timeline.Stop();
    }

    private void Update()
    {
        if (player.cutscene == true)
        {
            timeline.Play();
            canvas1Hub.enabled = false;
            timeTotimeline -= Time.deltaTime;
        }
        if (timeTotimeline <= 1)
        {
            level.Transition("Vitoria");
        }
    }



}
