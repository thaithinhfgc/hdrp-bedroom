using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLoader : MonoBehaviour
{
    [SerializeField] private GameObject lightButtonPrefab;
    void Start()
    {
        foreach (LightScriptableObject lightScriptableObject in GameManager.Instance.lightScriptableObjects)
        {
            GameObject lightButton = Instantiate(lightButtonPrefab, transform);
            lightButton.GetComponent<LightDisplay>().lightScriptableObject = lightScriptableObject;
        }
    }
}
