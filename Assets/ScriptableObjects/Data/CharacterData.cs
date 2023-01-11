using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData", order = 0)]
public class CharacterData : ScriptableObject
{

    public float speed;
    public float currentMoney;
    public ScriptableObject equippedHeadPart;
    public ScriptableObject equippedBodyPart;
    public List<BodyPart> headParts;
    public List<BodyPart> bodyParts;
}
