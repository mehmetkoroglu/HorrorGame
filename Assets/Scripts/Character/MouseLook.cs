using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    Camera cam;
    bool zoom = false;
    public float mouseSensivity = 50f;
    public Transform player;
    float xRotation = 0f;

    public GameObject optionsMenu;

    public static MouseLook Instance;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cam = gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 48f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (!zoom)
            {
                cam.fieldOfView = 30;
                zoom = !zoom;
            }
            else if (zoom)
            {
                cam.fieldOfView = 60;
                zoom = !zoom;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !TextController.Instance.text.activeSelf)
        {
            optionsMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Instance.enabled = false;
            PlayerMove.Instance.enabled = false;
        }
    }
}
