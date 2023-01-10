using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        playerControllerInstance.SetIdle();
    }

}
