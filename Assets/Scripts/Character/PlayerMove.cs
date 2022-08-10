using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController characterControl;

    public Animator animator;
    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;


    bool isGrounded;
    public float speed = 1.5f;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    Vector3 velocity;

    public static PlayerMove Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        speed = Input.GetKey(KeyCode.LeftShift) ? 4f : 1.5f;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        animator.GetComponent<Animator>().SetBool("isMove", (x != 0 || z != 0));

        characterControl.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        characterControl.Move(velocity * Time.deltaTime);
    }
}
