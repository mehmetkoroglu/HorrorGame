using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : objects
{

    public override void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            string lightName = gameObject.name.Substring(0, gameObject.name.IndexOf("_"));
            LightOpenClose.Instance.OpenOrCloseLight(lightName);
        }
    }
}
