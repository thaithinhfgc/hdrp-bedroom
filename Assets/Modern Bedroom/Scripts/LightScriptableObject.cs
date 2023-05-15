using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Light", menuName = "ScriptableObjects/New Light")]
public class LightScriptableObject : ScriptableObject
{
    public string lightName;
    public Color color;
}
