using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] lights;
    public LightScriptableObject[] lightScriptableObjects;
    public GameObject[] lightObjects;
    public BlanketScriptableObject[] blanketScriptableObjects;
    public GameObject blanketObject;
    public FloorScriptableObject[] floorScriptableObjects;
    public GameObject floorObject;
    public WallScriptableObject[] wallScriptableObjects;
    public GameObject[] wallsObject;
    public static GameManager Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        lightScriptableObjects = Resources.LoadAll<LightScriptableObject>("Lights");
        blanketScriptableObjects = Resources.LoadAll<BlanketScriptableObject>("Blankets");
        floorScriptableObjects = Resources.LoadAll<FloorScriptableObject>("Floors");
        wallScriptableObjects = Resources.LoadAll<WallScriptableObject>("Walls");
    }

    public void ChangeLight(LightScriptableObject lightScriptableObject)
    {
        foreach (GameObject lightObject in lightObjects)
        {
            lightObject.GetComponent<Light>().color = lightScriptableObject.color;
        }
    }

    public void ChangeBlanket(BlanketScriptableObject newBlanketScriptableObject)
    {
        Renderer renderer = blanketObject.GetComponent<Renderer>();
        renderer.material.mainTexture = newBlanketScriptableObject.blanketBaseMap;
        renderer.material.SetTexture("_NormalMap", newBlanketScriptableObject.blanketNormalMap);
    }

    public void ChangeFloor(FloorScriptableObject newFloorScriptableObject)
    {
        Renderer renderer = floorObject.GetComponent<Renderer>();
        renderer.material.mainTexture = newFloorScriptableObject.floorBaseMap;
        renderer.material.SetTexture("_NormalMap", newFloorScriptableObject.floorNormalMap);
    }

    public void ChangeWall(WallScriptableObject newWallScriptableObject)
    {
        foreach (GameObject wallObject in wallsObject)
        {
            Renderer renderer = wallObject.GetComponent<Renderer>();
            renderer.material.mainTexture = newWallScriptableObject.wallBaseMap;
            renderer.material.SetTexture("_NormalMap", newWallScriptableObject.wallNormalMap);
        }
    }
}
