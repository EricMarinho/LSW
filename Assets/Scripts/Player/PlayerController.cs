using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [HideInInspector] public Rigidbody2D rb;
    public CharacterData playerData;
    private MovementHandler movementHandler;
    private InputManager inputManager;

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
        inputManager = GetComponent<InputManager>();
    }

    public void moveCharacter()
    {
        movementHandler.ChangeTarget();
    }

}
