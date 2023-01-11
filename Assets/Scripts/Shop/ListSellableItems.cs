using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListSellableItems : MonoBehaviour
{
    private PlayerController playerControllerInstance;
    [SerializeField] private string bodyPartType;
    [SerializeField] private GameObject bodyPartPrefab;
    void OnEnable()
    {
        playerControllerInstance = PlayerController.instance;
        if (bodyPartType == "Body")
        {
            foreach (BodyPart bodyPart in playerControllerInstance.playerData.bodyParts)
            {
                if (bodyPart.isSellable)
                {
                    GameObject instantiatedItem = Instantiate(bodyPartPrefab, transform);
                    instantiatedItem.GetComponent<SellingItemManager>().item = bodyPart;
                    instantiatedItem.GetComponent<Image>().sprite = bodyPart.icon;
                    instantiatedItem.GetComponentInChildren<TMP_Text>().text = bodyPart.price.ToString() + " coins";
                }
            }
        }
        else
        {
            foreach (BodyPart bodyPart in playerControllerInstance.playerData.headParts)
            {
                if (bodyPart.isSellable)
                {
                    GameObject instantiatedItem = Instantiate(bodyPartPrefab, transform);
                    instantiatedItem.GetComponent<SellingItemManager>().item = bodyPart;
                    instantiatedItem.GetComponent<Image>().sprite = bodyPart.icon;
                    instantiatedItem.GetComponentInChildren<TMP_Text>().text = bodyPart.price.ToString() + " coins";
                }
            }
        }

    }

}
