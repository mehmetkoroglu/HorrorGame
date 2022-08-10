using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapi : objects
{
    public override void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ItemsController.Instance.CanOpenDoor(transform.parent.name))
            {
                MusicController.Instance.PlayDoorOpenClip();
                Animator a = transform.GetComponentInParent<Animator>();
                a.SetBool(a.GetParameter(0).name, !a.GetBool(a.GetParameter(0).name));
            }
            else
            {
                MusicController.Instance.PlayLockedDoorClip();
            }
        }
    }
}
