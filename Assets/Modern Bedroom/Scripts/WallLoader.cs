using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLoader : MonoBehaviour
{
    [SerializeField] private GameObject wallButtonPrefab;
    void Start()
    {
        foreach (WallScriptableObject wallScriptableObject in GameManager.Instance.wallScriptableObjects)
        {
            GameObject wallButton = Instantiate(wallButtonPrefab, transform);
            wallButton.GetComponent<WallDisplay>().wallScriptableObject = wallScriptableObject;
        }
    }
}
