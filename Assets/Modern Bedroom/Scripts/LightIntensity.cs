using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightIntensity : MonoBehaviour
{
    [SerializeField] private GameObject[] lightObjects;
    [SerializeField] private Slider slider;
    [SerializeField] private float minLight = 0f;
    [SerializeField] private float maxLight = 500f;
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.minValue = minLight;
        slider.maxValue = maxLight;
        slider.value = maxLight;
        slider.onValueChanged.AddListener(delegate { ChangeLightSensitive(); });
    }

    public void ChangeLightSensitive()
    {
        foreach (GameObject lightObject in lightObjects)
        {
            lightObject.GetComponent<Light>().intensity = slider.value;
        }
    }

}
