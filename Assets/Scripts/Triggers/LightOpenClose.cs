using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOpenClose : MonoBehaviour
{
    public static LightOpenClose Instance;
    public bool isElectricityGone = false;

    GameObject[] lights;

    private void Awake()
    {
        Instance = this;
        lights = GameObject.FindGameObjectsWithTag("emission");
        CloseAllLights();
    }

    public void OpenOrCloseLight(string lightName)
    {
        foreach (GameObject light in lights)
        {
            if (light.name.Equals(lightName) && !isElectricityGone)
            {
                if (!light.GetComponentInChildren<Light>().enabled)
                {
                    light.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
                    light.GetComponentInChildren<Light>().enabled = true;
                }
                else
                {
                    light.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
                    light.GetComponentInChildren<Light>().enabled = false;
                }
            }
        }
    }

    public void CloseAllLights()
    {
        foreach (GameObject light in lights)
        {
            light.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            light.GetComponentInChildren<Light>().enabled = false;
        }
    }
}
