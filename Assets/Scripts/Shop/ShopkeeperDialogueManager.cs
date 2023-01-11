using System.Collections;
using UnityEngine;
using TMPro;

public class ShopkeeperDialogueManager : MonoBehaviour
{

    public TMP_Text text;
    public GameObject exitButton;

    public void ChangeText()
    {
        text.text = "You look like you need some coins, here buddy!";
        MoneyManager.instance.AddMoney(20);
        StartCoroutine(WaitForNextText());
    }

    IEnumerator WaitForNextText()
    {
        yield return new WaitForSeconds(3);
        text.text = "I'm a shopkeeper. I sell stuff, you buy stuff, we're all happy. You can equip your clothes in the fitting room on the left corner.";
        exitButton.SetActive(true);
    }

}
