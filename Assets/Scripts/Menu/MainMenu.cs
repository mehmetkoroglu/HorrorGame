using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    
    public static MainMenu Instance;
    public bool menuControlOption = false;

    void Awake()
    {
        if(Instance == null){
            Instance = this;
        }
    }

    public void Play(){
        SceneManager.LoadScene(1);
    }
    public void OptionMenu(){
        optionsMenu.SetActive(!menuControlOption);
    }

    public void Exit(){
        Debug.Log("quit");
        Application.Quit();
    }
}
