using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    static Transform playerTransform;
    
    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
    }



    
   
}
