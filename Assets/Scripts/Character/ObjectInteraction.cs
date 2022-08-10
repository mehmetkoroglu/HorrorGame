using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObjectInteraction : MonoBehaviour
{
    public float distance = 6f;
    public GameObject thunder;
    public GameObject itemUI;

    private void Start()
    {
        thunder.SetActive(false);
    }

    void Update()
    {
        Vector3 forwardDirection = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forwardDirection, out RaycastHit hit, distance))
        {
            Debug.DrawRay(transform.position, forwardDirection * distance, Color.red);

            objects object_ = hit.collider.gameObject.GetComponent<objects>();

            if (object_ != null)
            {
                object_.trigger();
            }

            itemUI.SetActive(object_ != null);
        }
    }
}
