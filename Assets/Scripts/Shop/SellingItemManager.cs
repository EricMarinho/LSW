using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellingItemManager : MonoBehaviour
{
    [HideInInspector] public BodyPart item;
    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
        if (item.isEquiped)
        {
            GetComponentInChildren<TMP_Text>().text = "Equipped";
            GetComponentInChildren<TMP_Text>().color = Color.red;
        }

    }

    public void SellItem()
    {
        if (item.isEquiped) return;

        item.isBuyable = true;
        item.isObtained = false;
        item.isSellable = false;
        MoneyManager.instance.AddMoney(item.price);
        (item.bodyPart == "Head" ? playerControllerInstance.playerData.headParts : playerControllerInstance.playerData.bodyParts).Remove(item);

        Object.Destroy(gameObject);
    }

}
