using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/CharacterData", order = 0)]
public class CharacterData : ScriptableObject
{

    public float speed;
    public Sprite headClothes;
    public Sprite upperClothes;
    public Sprite lowerClothes;

}
