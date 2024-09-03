using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newfps : MonoBehaviour
{
    [Header("Movement Speed")]
    [SerializeField] private float walkSpeed = 3.0f;
    [SerializeField] private float sprintMultiplier = 4.0f;

    [Header("Jump Parameters")]
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] private float gravity = 9.81f;

    [Header("Looking Sensitivity")]
    [SerializeField] private float mouseSensitivity = 2.0f;
    [SerializeField] private float upDownRange = 80.0f;

    [Header("Inputs Move")]
    [SerializeField] private string horizontalMoveInput = "Horizontal";
    [SerializeField] private string verticalMoveInput = "Vertical";
    [SerializeField] private string MouseXInput = "Mouse X";
    [SerializeField] private string MouseYInput = "Mouse Y";
    [SerializeField] private KeyCode sprintKey = KeyCode.LeftShift;
    [SerializeField] private KeyCode jumpKey = KeyCode.Space;

    private Camera MainCamera;
    private float verticalRotation;
    private Vector3 currentMovement = Vector3.zero;
    private CharacterController characterController; 

    // Start is called before the first frame update
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        MainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Update is called once per frame
    private void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleMovement()
    {
        float speedMultipier = Input.GetKey(sprintKey) ? sprintMultiplier : 1f;
        float verticalSpeed = Input.GetAxis(verticalMoveInput) * walkSpeed * speedMultipier;
        float horizontalSpeed = Input.GetAxis(horizontalMoveInput) * walkSpeed * speedMultipier;
    
        Vector3 horizontalMovement = new Vector3 (horizontalSpeed,0,verticalSpeed);
        horizontalMovement = transform.rotation * horizontalMovement;

        HandleGravityAndJumping();

        currentMovement.x = horizontalMovement.x;
        currentMovement.z = horizontalMovement.z; 

        characterController.Move(currentMovement * Time.deltaTime);
    }

    void HandleGravityAndJumping()
    {
        if(characterController. isGrounded){
           currentMovement.y = -.5f;

           if(Input.GetKeyDown(jumpKey)){
               currentMovement.y = jumpForce;
           }
        }
        else
        {
            currentMovement.y -= gravity * Time.deltaTime;
        } 
    }
    void HandleRotation()
    {
        float MouseXRotation = Input.GetAxis(MouseXInput) * mouseSensitivity;
        transform.Rotate(0, MouseXRotation, 0);
    
        verticalRotation -= Input.GetAxis(MouseYInput) * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange,upDownRange);
        MainCamera.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);
    }
}