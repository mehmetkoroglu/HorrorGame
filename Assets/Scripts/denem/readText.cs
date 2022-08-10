using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readText : objects
{
    public override void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            TextController.Instance.showText(gameObject);
            if (gameObject.name.Equals("readText_4")) JumpScareController.Instance.jumpScareTrigger2.SetActive(true);
        }
    }
}
