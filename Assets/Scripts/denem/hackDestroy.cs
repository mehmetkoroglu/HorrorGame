using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class hackDestroy : objects
{
    public override void trigger()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
             if(ItemsController.Instance.keys.Contains("hac")) SceneManager.LoadScene(3, LoadSceneMode.Single); 
        }
       
    }
}
