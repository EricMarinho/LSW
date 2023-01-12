using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{

    [HideInInspector] public BodyPart item;
    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;

    }

    public void ChangeClothes()
    {
        if (item.bodyPart == "Head")
        {
            playerControllerInstance.playerData.equippedHeadPart = item;
        }
        else if (item.bodyPart == "Body")
        {
            playerControllerInstance.playerData.equippedBodyPart = item;
        }

        foreach (BodyPart bodyPart in item.bodyPart == "Head" ? playerControllerInstance.playerData.headParts : playerControllerInstance.playerData.bodyParts)
        {
            bodyPart.isEquiped = false;
        }

        item.isEquiped = true;



    }

}
