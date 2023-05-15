using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Wall", menuName = "ScriptableObjects/New Wall")]

public class WallScriptableObject : ScriptableObject
{
     public string wallName;
    public string wallDescription;
    public Sprite icon;
    public Texture2D wallBaseMap;
    public Texture2D wallNormalMap;
}
