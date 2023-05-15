using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private CharacterController characterController;

    [SerializeField] private float moveSpeed;
    private Vector3 dragOrigin;
    public float mouseSensitivity = 100.0f;
    private bool rotateCamera = false;
    private float rotX = 0.0f;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private bool canInput;
    void Start()
    {

        Vector3 rot = transform.localRotation.eulerAngles;
        rotX = rot.x;
        canInput = true;
    }
    void Update()
    {
        CheckCanInput();
        if (!canInput) return;
        LookAround();
        Move();
    }

    void CheckCanInput()
    {
        if (GameObject.FindGameObjectsWithTag("UISelect").Length > 0)
        {
            canInput = false;
        }
        else
        {
            canInput = true;
        }
    }

    void LookAround()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotateCamera = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            rotateCamera = false;
        }

        if (rotateCamera)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            rotX -= mouseY;
            rotX = Mathf.Clamp(rotX, -90.0f, 90.0f);

            cameraTransform.localRotation = Quaternion.Euler(rotX, 0.0f, 0.0f);
            transform.Rotate(Vector3.up * mouseX);
        }
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move * moveSpeed * Time.deltaTime);
        groundedPlayer = characterController.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        playerVelocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }
}
