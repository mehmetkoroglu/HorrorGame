using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class SkipStory : MonoBehaviour
{
    public PlayableDirector a;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            a.time +=12;
           
        }
    }
}
