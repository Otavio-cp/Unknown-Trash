using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class ColliderCena : MonoBehaviour
{

    private float timer = 2;

    [SerializeField] LevelLoading levelLoading;
    [SerializeField] AudioSource click;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelLoading.Transition("Vitoria");
        }
    }
}