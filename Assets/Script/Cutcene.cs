using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Cutcene : MonoBehaviour
{
    [SerializeField] PlayableDirector timeline;
    [SerializeField] float timeTotimeline = 8.566f;  // EU amo o FAKER do League Of Legends >:3
    [SerializeField] Player player;

    private void Update()
    {
        if (player.cutscene == true)
        {
            timeline.Play();
            Invoke("Vitoria", timeTotimeline);
        }
    }



}
