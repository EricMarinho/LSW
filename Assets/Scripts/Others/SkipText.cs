using System.Collections;
using UnityEngine;
using TMPro;

public class SkipText : MonoBehaviour
{

    public TMP_Text text;

    public void ChangeText()
    {
        text.text = "You look like you need some coins, here buddy!";
        StartCoroutine(WaitForNextText());
    }

    IEnumerator WaitForNextText()
    {
        yield return new WaitForSeconds(3);
        text.text = "I'm a shopkeeper, I sell stuff, you buy stuff, we're all happy.";
    }

}
