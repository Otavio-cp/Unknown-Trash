using UnityEngine;
using UnityEngine.UI;

public class Trasicao : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Image fadeimage;
    public void trasiçãocomeçar()
    {
        fadeimage.enabled = true;
        animator.Play("Trasiçãodetirar");
    }
}
