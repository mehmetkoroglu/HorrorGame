using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class fpsCounter : MonoBehaviour
{
    public TextMeshProUGUI fps;
    private float pollingTime = 1f;
    private float time;
    private int frame;

    
    void Update()
    {
        time+=Time.deltaTime;
        frame++;

        if(time>= pollingTime){
            int frameRate = Mathf.RoundToInt(frame/time);
            fps.text = frameRate.ToString() + " FPS";
            time -= pollingTime;
            frame = 0;
        }
    }
}
