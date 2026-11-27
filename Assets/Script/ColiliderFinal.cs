using UnityEngine;

public class ColiliderFinal : MonoBehaviour
{
    [SerializeField] LevelLoading levelLoading;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelLoading.Transition("Vitoria");
        }
    }
}
