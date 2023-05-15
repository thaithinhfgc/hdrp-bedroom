using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorDisplay : MonoBehaviour
{
    public FloorScriptableObject floorScriptableObject;
    public Image image;
    private Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ChangeFloor(); });
        image.sprite = floorScriptableObject.icon;
    }

    public void ChangeFloor()
    {
        GameManager.Instance.ChangeFloor(floorScriptableObject);
    }
}
