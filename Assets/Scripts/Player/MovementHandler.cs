using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    private PlayerController playerControllerInstance;
    private Vector3 targetPosition;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
        targetPosition = transform.position;
    }

    public void ChangeTarget()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(playerControllerInstance.rb.transform.position, targetPosition, playerControllerInstance.playerData.speed * Time.deltaTime);
    }
}
