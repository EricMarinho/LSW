using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [HideInInspector] public Rigidbody2D rb;
    public CharacterData playerData;
    private MovementHandler movementHandler;
    private PlayerAnimationHandler animationHandler;
    public bool isMovable { get; set; } = true;

    #region Singleton

    public static PlayerController instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    #endregion

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementHandler = GetComponent<MovementHandler>();
        animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    public void moveCharacter()
    {
        movementHandler.ChangeTarget();
    }

    public void SetLookDirection(float lookX, float lookY)
    {
        animationHandler.SetLookDirection(lookX, lookY);
    }

    public void SetIdle()
    {
        animationHandler.SetAnimationIdle();
    }

    public void SetWalinkg()
    {
        animationHandler.SetAnimationWalking();
    }

}
