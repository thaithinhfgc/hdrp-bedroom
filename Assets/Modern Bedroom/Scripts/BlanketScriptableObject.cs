using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Blanket", menuName = "ScriptableObjects/New Blanket")]
public class BlanketScriptableObject : ScriptableObject
{
    public string blanketName;
    public string blanketDescription;
    public Sprite icon;
    public Texture2D blanketBaseMap;
    public Texture2D blanketNormalMap;
    
}
