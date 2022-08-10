using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{

    public static Thunder Instance;
    float timer = 0f;
    public Light thunderLight;
    AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer -= 1f * Time.deltaTime;
        if (timer <= 0)
        {
            thunder();
        }
    }

    public void thunder()
    {
        timer = 30f;
        StartCoroutine(thunderTimer());
    }

    IEnumerator thunderTimer()
    {
        
        thunderLight.intensity = 1;
        yield return new WaitForSeconds(0.2f);
        audioSource.Play();
        thunderLight.intensity = 0;
        yield return new WaitForSeconds(1f);
        thunderLight.intensity = 1;
        
        yield return new WaitForSeconds(0.2f);
        thunderLight.intensity = 0;
        yield return new WaitForSeconds(2f);
        thunderLight.intensity = 1;
        yield return new WaitForSeconds(0.4f);
        thunderLight.intensity = 0;
        yield return new WaitForSeconds(0.5f);
        thunderLight.intensity = 1;
        yield return new WaitForSeconds(0.2f);
        thunderLight.intensity = 0;
    }
}
