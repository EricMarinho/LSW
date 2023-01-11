using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellingItemManager : MonoBehaviour
{
    [HideInInspector] public BodyPart item;
    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;

    }

    public void SellItem()
    {
        item.isBuyable = true;
        item.isObtained = false;
        item.isSellable = false;
        MoneyManager.instance.AddMoney(item.price);

        if (item.bodyPart == "Head")
        {
            playerControllerInstance.playerData.headParts.Remove(item);
        }
        else if (item.bodyPart == "Body")
        {
            playerControllerInstance.playerData.bodyParts.Remove(item);
        }

        Object.Destroy(gameObject);
    }

}
