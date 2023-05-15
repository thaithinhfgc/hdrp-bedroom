using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Floor", menuName = "ScriptableObjects/New Floor")]

public class FloorScriptableObject : ScriptableObject
{
    public string floorName;
    public string floorDescription;
    public Sprite icon;
    public Texture2D floorBaseMap;
    public Texture2D floorNormalMap;
}

