using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
    }

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            playerControllerInstance.moveCharacter();
        }
    }

}
