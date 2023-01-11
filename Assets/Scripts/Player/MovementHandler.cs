using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    private PlayerController playerControllerInstance;
    private Vector3 targetPosition;
    private Vector2 lookDirection = new Vector2(1, 0);

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
        targetPosition = transform.position;
    }

    public void ChangeTarget()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        lookDirection = targetPosition - transform.position;
        lookDirection.Normalize();
        playerControllerInstance.SetLookDirection(lookDirection.x, lookDirection.y);
        playerControllerInstance.SetWalinkg();
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(playerControllerInstance.rb.transform.position, targetPosition, playerControllerInstance.playerData.speed * Time.deltaTime);
        if (transform.position != targetPosition) return;
        playerControllerInstance.SetIdle();
    }
}
