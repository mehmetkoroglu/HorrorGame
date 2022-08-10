using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{

    public Light flashlight;
    public float batteryLevel = 100f;
    bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        flashlight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // builtten önce F tuşu yap !!!! mK
        {
            isOpen = !isOpen;
            flashlight.gameObject.SetActive(isOpen);
        }

        if (isOpen && ItemsController.Instance.flashlight_batteries > 0)
        {
            batteryLevel -= 10 * Time.deltaTime;

            if (batteryLevel <= 0)
            {
                batteryLevel = 100f;
                flashlight.intensity = 2f;
                ItemsController.Instance.flashlight_batteries--;
            }

            if (batteryLevel <= 50) flashlight.intensity = 1f;
            if (batteryLevel <= 25) flashlight.intensity = 0.5f;

        }

        if (ItemsController.Instance.flashlight_batteries == 0)
        {
            flashlight.gameObject.SetActive(false);
            isOpen = false;
        }
    }
}
