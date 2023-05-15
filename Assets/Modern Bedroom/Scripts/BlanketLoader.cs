using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlanketLoader : MonoBehaviour
{
    [SerializeField] private GameObject blanketButtonPrefab;
    void Start()
    {
        foreach (BlanketScriptableObject blanketScriptableObject in GameManager.Instance.blanketScriptableObjects)
        {
            GameObject blanketButton = Instantiate(blanketButtonPrefab, transform);
            blanketButton.GetComponent<BlanketDisplay>().blanketScriptableObject = blanketScriptableObject;
        }
    }
}
