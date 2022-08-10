using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salter : objects
{
    public override void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Thunder.Instance.gameObject.SetActive(false);
            LightOpenClose.Instance.isElectricityGone = false;
        }
    }
}
