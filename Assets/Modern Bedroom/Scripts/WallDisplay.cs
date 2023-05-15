using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallDisplay : MonoBehaviour
{
    public WallScriptableObject wallScriptableObject;
    public Image image;
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ChangeWall(); });
        image.sprite = wallScriptableObject.icon;
    }

    public void ChangeWall()
    {
        GameManager.Instance.ChangeWall(wallScriptableObject);
    }
}
