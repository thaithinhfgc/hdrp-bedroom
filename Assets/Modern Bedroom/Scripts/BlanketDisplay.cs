using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlanketDisplay : MonoBehaviour
{
    public BlanketScriptableObject blanketScriptableObject;
    public Image image;
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ChangeBlanket(); });
        image.sprite = blanketScriptableObject.icon;
    }

    public void ChangeBlanket()
    {
        GameManager.Instance.ChangeBlanket(blanketScriptableObject);
    }
}
