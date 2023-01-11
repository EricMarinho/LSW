using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BuyingItemManager : MonoBehaviour
{

    [SerializeField] BodyPart item;
    [SerializeField] TMP_Text priceText;
    private PlayerController playerControllerInstance;

    private MoneyManager moneyManagerInstance;

    private void OnEnable()
    {
        if (item.isBuyable)
        {
            priceText.text = item.price.ToString() + " coins";
            priceText.color = Color.white;
        }
        else
        {
            priceText.text = "Sold!";
            priceText.color = Color.red;
        }
        moneyManagerInstance = MoneyManager.instance;
        playerControllerInstance = PlayerController.instance;
        gameObject.GetComponent<Image>().sprite = item.icon;
    }

    public void BuyItem()
    {
        if (moneyManagerInstance.CanAfford(item.price) && item.isBuyable)
        {
            item.isBuyable = false;
            item.isObtained = true;
            item.isSellable = true;
            moneyManagerInstance.RemoveMoney(item.price);
            priceText.text = "Sold!";
            priceText.color = Color.red;
            if (item.bodyPart == "Head")
            {
                playerControllerInstance.playerData.headParts.Add(item);
            }
            else if (item.bodyPart == "Body")
            {
                playerControllerInstance.playerData.bodyParts.Add(item);
            }
        }
    }

}
