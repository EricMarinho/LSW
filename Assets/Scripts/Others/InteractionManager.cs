using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractionManager : MonoBehaviour, IPointerClickHandler
{

    private PlayerController playerControllerInstance;
    public GameObject interfacePanel;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!playerControllerInstance.isMovable) return;

        playerControllerInstance.moveCharacter();
        interfacePanel.SetActive(true);
        playerControllerInstance.isMovable = false;
    }

    public void ExitShop()
    {
        playerControllerInstance.isMovable = true;
    }

}
