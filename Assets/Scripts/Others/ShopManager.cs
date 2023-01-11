using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ShopManager : MonoBehaviour, IPointerClickHandler
{

    private PlayerController playerControllerInstance;
    public GameObject shopPanel;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (playerControllerInstance.isMovable)
        {
            playerControllerInstance.moveCharacter();
            shopPanel.SetActive(true);
            playerControllerInstance.isMovable = false;
        }
    }

    public void ExitShop()
    {
        playerControllerInstance.isMovable = true;
    }

}
