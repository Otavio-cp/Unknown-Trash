using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public static float timer = 30;
    [SerializeField]
    private Animator _TimerAni;

    public static TMP_Text _timer;
    void Start()
    {
        _timer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer.text = "Timer Remainder: " + timer.ToString("N0");
        timer -= Time.deltaTime;
        if (timer <= 10)
        {
            _TimerAni.SetBool("isAniTimer", true);
        }
        else
        {
            _TimerAni.SetBool("isAniTimer", false);
        }
    }
}
