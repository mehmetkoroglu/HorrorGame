using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : objects
{
   public override void trigger()
    {
       
       if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Animator a = transform.GetComponentInParent<Animator>();
            a.SetBool(a.GetParameter(0).name,!a.GetBool(a.GetParameter(0).name));           
            
        }
    }
}
