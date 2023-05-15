using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject lightPanel;
    [SerializeField] private GameObject blanketPanel;
    [SerializeField] private GameObject wardrobePanel;
    [SerializeField] private GameObject wallPanel;
    [SerializeField] private GameObject floorPanel;
    [SerializeField] private FirstPersonController firstPersonController;
    void Start()
    {
        SetDefault();
    }

    public void SetDefault()
    {
        lightPanel.SetActive(false);
        blanketPanel.SetActive(false);
        wardrobePanel.SetActive(false);
        wallPanel.SetActive(false);
        floorPanel.SetActive(false);
    }
    public void ActivePanel(GameObject panel)
    {
        SetDefault();
        panel.SetActive(true);
    }
}
