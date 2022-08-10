using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public static GameMenu Instance;

    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;
    Resolution[] resolutions;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MouseLook.Instance.enabled = true;
            GameMenu.Instance.gameObject.SetActive(false);
            PlayerMove.Instance.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
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
            options.Add(resolutions[i].ToString());
            if (resolutions[i].width.Equals(Screen.currentResolution.width) &&
                resolutions[i].height.Equals(Screen.currentResolution.height)) currentResolutionIndex = i;            
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetVolume(float volume) => audioMixer.SetFloat("volume", volume);

    public void SetQuality(int qualityLevel) => QualitySettings.SetQualityLevel(qualityLevel);

    public void Fullscreen(bool fullscreenControl) => Screen.fullScreen = fullscreenControl;

    public void SetVSync(bool value) => QualitySettings.vSyncCount = value ? 1 : 0;

    public void SetMouseSensivity(float sensivity) => MouseLook.Instance.mouseSensivity = sensivity;

    public void mainMenu() => SceneManager.LoadScene(0);

    public void SetResolution(int resolutioIndex)
    {
        Resolution resolution = resolutions[resolutioIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void BackToMenu()
    {
        //MainMenu.Instance.optionsMenu.SetActive(MainMenu.Instance.menuControlOption);
        MouseLook.Instance.enabled = true;
        GameMenu.Instance.gameObject.SetActive(false);
        PlayerMove.Instance.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}