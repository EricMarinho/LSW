using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BodyPart", menuName = "ScriptableObjects/BodyPart", order = 2)]
public class BodyPart : ScriptableObject
{
    public string bodyPart;
    public string clothesName;
    public int id;
    public bool isSellable;
    public bool isBuyable;
    public bool isObtained;
    public bool isEquiped;
    public float price;
    public Sprite icon;
}
