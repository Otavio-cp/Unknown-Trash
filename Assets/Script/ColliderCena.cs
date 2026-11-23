using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class ColliderCena : MonoBehaviour
{

    private float timer = 2;

    [SerializeField] LevelLoading levelLoading;
    [SerializeField] AudioSource click;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer >= 16)
        {
            levelLoading.Transition("tutorial");
        }
    }

    public void Pular()
    {
        levelLoading.Transition("tutorial");
        click.Play();
    }

}