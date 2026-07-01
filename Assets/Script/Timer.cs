using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timer = 60;

    [SerializeField] private Color _color1 = Color.white;
    [SerializeField] private Color _color2 = Color.red;
    [SerializeField] private float _duration = 1f;
    [SerializeField] private TMP_Text texto;

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

        if (timer <= 10f)
        {
            float t = Mathf.PingPong(timer * _duration, 1f);
            texto.color = Color.Lerp(_color1, _color2, t);

            _TimerAni.SetBool("isAniTime", true);
        }
        else
        {
            _TimerAni.SetBool("isAniTime", false);
        }
    }
}
