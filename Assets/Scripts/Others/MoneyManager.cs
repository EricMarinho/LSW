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
    [SerializeField] private GameObject moneyChangeText;
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

        GameObject moneyChangeTextInstance = Instantiate(moneyChangeText, moneyText.transform.position, Quaternion.identity, moneyText.transform.parent);
        moneyChangeTextInstance.GetComponent<TMP_Text>().text = "+" + amount.ToString();
        moneyChangeTextInstance.GetComponent<TMP_Text>().color = Color.green;

    }

    public void RemoveMoney(float amount)
    {
        playerControllerInstance.playerData.currentMoney -= amount;
        moneyText.text = playerControllerInstance.playerData.currentMoney.ToString() + " coins";

        GameObject moneyChangeTextInstance = Instantiate(moneyChangeText, moneyText.transform.position, Quaternion.identity, moneyText.transform.parent);
        moneyChangeTextInstance.GetComponent<TMP_Text>().text = "-" + amount.ToString();
        moneyChangeTextInstance.GetComponent<TMP_Text>().color = Color.red;
    }

    public bool CanAfford(float amount)
    {
        return playerControllerInstance.playerData.currentMoney >= amount;
    }

}
