using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTrigger : MonoBehaviour
{
    AudioSource audioSource;
    Animator animator;

    public GameObject candles,table;

    public Material tableMaterial;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("jumpScareTrigger") || other.gameObject.name.Equals("jumpScareTrigger2") )
        {
            audioSource.PlayOneShot(audioSource.clip);
        }
        if (other.gameObject.name.Equals("streetLamp"))
        {
            MusicController.Instance.PlayDogBark();
            Destroy(other.gameObject.GetComponent<BoxCollider>());
        }
        if (other.gameObject.name.Equals("candles"))
        {
            candles.SetActive(true);
            LightOpenClose.Instance.CloseAllLights();
            table.GetComponent<Renderer>().material = tableMaterial;
            MusicController.Instance.PlayCandlesMusic();
        }
    }

    void animationEdit1()
    {
        animator.speed = 0.01f;
    }
    void animationEdit2()
    {
        animator.speed = 0.7f;
    }
}
