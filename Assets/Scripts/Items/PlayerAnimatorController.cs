using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimatorController : MonoBehaviour
{
    public Animator animator;
    public UnityEvent onJump;
    public UnityEvent onLand;

    void Start()
    {
        if (onJump == null)
            onJump = new UnityEvent();

        if (onLand == null)
            onLand = new UnityEvent();
    }

    public void Jump()
    {
        animator.SetTrigger("Jump");
        onJump.Invoke();
    }

    public void Land()
    {
        animator.SetTrigger("Land");
        onLand.Invoke();
    }
}
