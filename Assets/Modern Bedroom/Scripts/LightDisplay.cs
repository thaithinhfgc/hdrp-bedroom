using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightDisplay : MonoBehaviour
{
    public LightScriptableObject lightScriptableObject;
    public Image image;
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ChangeLight(); });
        image.color = lightScriptableObject.color;
        Color color = image.color;
        color.a = 1;
        image.color = color;
    }

    public void ChangeLight()
    {
        GameManager.Instance.ChangeLight(lightScriptableObject);
    }
}
