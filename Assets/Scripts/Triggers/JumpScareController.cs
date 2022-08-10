using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScareController : MonoBehaviour
{
    public static JumpScareController Instance;

    public GameObject jumpScareTrigger, jumpScareTrigger2, scary, scary2;
    public bool scaryActive = false;

    void Start()
    {
        Instance = this;
        scary.SetActive(false);
        jumpScareTrigger.SetActive(false);
        scary2.SetActive(false);
        jumpScareTrigger2.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("jumpScareTrigger"))
        {
            scary.SetActive(true);
            Destroy(scary, 0.3f);
            Destroy(jumpScareTrigger, 0.3f);
            scaryActive = true;
        }

        if (other.gameObject.name.Equals("jumpScareTrigger2"))
        {
            scary2.SetActive(true);
            Destroy(scary2, 0.3f);
            Destroy(jumpScareTrigger2, 0.3f);
        }
    }
}
