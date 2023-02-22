using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Light))]
public class ToggleLight : MonoBehaviour
{
    Light L;
    // public float intensity;
    float baseIntensity;

    void Start()
    {
        L = gameObject.GetComponent<Light>();

        baseIntensity = L.intensity;
    }

    // Update is called once per frame
    public void Toggle(){

        if (L.intensity > 0) L.intensity = 0;

        else if (L.intensity <= 0 ) L.intensity = baseIntensity;
    }
}
