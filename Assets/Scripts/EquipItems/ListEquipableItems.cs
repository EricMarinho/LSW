using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ListEquipableItems : MonoBehaviour
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
            if (!bodyPart.isObtained) continue;

            GameObject instantiatedItem = Instantiate(bodyPartPrefab, transform);
            instantiatedItem.GetComponent<EquipItem>().item = bodyPart;
            instantiatedItem.GetComponent<Image>().sprite = bodyPart.icon;
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
