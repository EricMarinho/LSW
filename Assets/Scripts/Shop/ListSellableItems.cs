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

    private void Awake()
    {
        playerControllerInstance = PlayerController.instance;
    }

    void OnEnable()
    {
        foreach (BodyPart bodyPart in bodyPartType == "Body" ? playerControllerInstance.playerData.bodyParts : playerControllerInstance.playerData.headParts)
        {
            if (!bodyPart.isSellable) continue;

            GameObject instantiatedItem = Instantiate(bodyPartPrefab, transform);
            instantiatedItem.GetComponent<SellingItemManager>().item = bodyPart;
            instantiatedItem.GetComponent<Image>().sprite = bodyPart.icon;
            instantiatedItem.GetComponentInChildren<TMP_Text>().text = bodyPart.price.ToString() + " coins";
        }
    }

    private void OnDisable()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

}
