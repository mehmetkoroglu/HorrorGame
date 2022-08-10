using UnityEngine;

public class BorderController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isClose", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("isClose", false);
        }
    }
}
