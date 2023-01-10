using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{

    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetLookDirection(float lookX, float lookY)
    {
        animator.SetFloat("moveX", lookX);
        animator.SetFloat("moveY", lookY);
    }

    public void SetAnimationIdle()
    {
        animator.SetBool("isWalking", false);
    }

    public void SetAnimationWalking()
    {
        animator.SetBool("isWalking", true);
    }

}
