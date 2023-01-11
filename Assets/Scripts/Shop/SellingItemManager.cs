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
        (item.bodyPart == "Head" ? playerControllerInstance.playerData.headParts : playerControllerInstance.playerData.bodyParts).Remove(item);

        Object.Destroy(gameObject);
    }

}
