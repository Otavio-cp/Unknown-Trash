using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public static float timer = 60;
    
    public static TMP_Text _timer;
    void Start()
    {
        _timer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer.text = "Tempo Restante: " + timer.ToString("N0");
        timer -= Time.deltaTime;
    }
}
