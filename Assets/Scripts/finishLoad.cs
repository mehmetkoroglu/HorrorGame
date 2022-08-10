using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finishLoad : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
