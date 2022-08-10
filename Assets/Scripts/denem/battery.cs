using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battery : objects
{
    public override void trigger()
    {
        Color a = new Color(0f, 0f, 0f, 1.0f);
        Color b = new Color(0f, 0f, 0f, 0.1f);
        gameObject.GetComponent<Renderer>().material.color = Color.Lerp(a, b, Mathf.PingPong(Time.time, 1));

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ItemsController.Instance.flashlight_batteries++;
            MusicController.Instance.PlayTakeBatteryClip();
            Destroy(gameObject);
        }
    }
}
