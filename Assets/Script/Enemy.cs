using UnityEngine;

public class Enemy : MonoBehaviour
{
    int damage = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player2>().TakeDamage(damage);
        }
    }
}

