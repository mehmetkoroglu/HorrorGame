using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;


    Resolution[] resolutions;

    public static OptionsMenu Instance;
     void Awake()
    {
        if(Instance == null){
            Instance = this;
        }
    }

  
    

     void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }


    public void SetVolume(float volume){
        
        audioMixer.SetFloat("volume",volume);
    }
    

    public void SetQuality(int qualityLevel){
        QualitySettings.SetQualityLevel(qualityLevel);
    }

    public void Fullscreen(bool fullscreenControl){
        Screen.fullScreen = fullscreenControl;
        Debug.Log(Screen.fullScreen);
    }

    public void SetResolution(int resolutioIndex){
        Resolution resolution = resolutions[resolutioIndex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }

    public void SetMouseSensivity(float sensivity){
        Debug.Log(sensivity);
        MouseLook.Instance.mouseSensivity = sensivity;
    }
    

    public void BackToMenu(){
        //MainMenu.Instance.optionsMenu.SetActive(MainMenu.Instance.menuControlOption);
        
        OptionsMenu.Instance.gameObject.SetActive(false);
        
    }
}
