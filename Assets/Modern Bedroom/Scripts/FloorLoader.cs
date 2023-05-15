using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorLoader : MonoBehaviour
{
    [SerializeField] private GameObject floorButtonPrefab;
    void Start()
    {
        foreach (FloorScriptableObject floorScriptableObject in GameManager.Instance.floorScriptableObjects)
        {
            GameObject floorButton = Instantiate(floorButtonPrefab, transform);
            floorButton.GetComponent<FloorDisplay>().floorScriptableObject = floorScriptableObject;
        }
    }
}
