using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{

    #region Singleton

    public static MoneyManager instance { get; private set; }
    private void Awake()
    {
        instance = this;
    }

    #endregion

    public TMP_Text moneyText;
    private PlayerController playerControllerInstance;

    private void Start()
    {
        playerControllerInstance = PlayerController.instance;
        moneyText.text = playerControllerInstance.playerData.currentMoney.ToString() + " coins";
    }

    public void AddMoney(float amount)
    {
        playerControllerInstance.playerData.currentMoney += amount;
        moneyText.text = playerControllerInstance.playerData.currentMoney.ToString() + " coins";
    }

    public void RemoveMoney(float amount)
    {
        playerControllerInstance.playerData.currentMoney -= amount;
        moneyText.text = playerControllerInstance.playerData.currentMoney.ToString() + " coins";
    }

    public bool CanAfford(float amount)
    {
        return playerControllerInstance.playerData.currentMoney >= amount;
    }

}
