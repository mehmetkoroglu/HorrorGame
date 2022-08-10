using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerBreak : objects
{
    public override void trigger()
    {
        Color a = new Color(1.0f, 0.9f, 0.4f, 1.0f);
        Color b = new Color(1.0f, 0.9f, 0.4f, 0.1f);
        gameObject.GetComponent<Renderer>().material.color = Color.Lerp(a, b, Mathf.PingPong(Time.time, 1));

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Thunder.Instance.gameObject.SetActive(true);
            LightOpenClose.Instance.CloseAllLights();
            LightOpenClose.Instance.isElectricityGone = true;
            ItemsController.Instance.keys.Add(gameObject.name.Substring(0, gameObject.name.IndexOf('_')));
            MusicController.Instance.PlayTakeKeyClip();
            Destroy(gameObject);
        }
    }
}
