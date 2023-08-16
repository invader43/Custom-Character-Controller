using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    AnimatorManager animatorManager;
    InputManager inputManager;
    [SerializeField] public Vector2 movementInput;
    [SerializeField] public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;
    public float verticalInput;
    public float horizontalInput;
    public float moveAmount;
    public float jump;
    public bool ispressed;



    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        inputManager = FindObjectOfType<InputManager>();
    }
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();
            playerControls.PlayerMovement.Jump.performed += i => jump = i.ReadValue<float>();
        }
        playerControls.Enable();
    }

    private void OnDisable()
    {
        if (playerControls != null)
        {
            playerControls.Disable();
        }
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        HandleCameraInput();
        //Other Inputs get called here
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
        moveAmount = Mathf.Clamp01(Mathf.Abs(verticalInput) + Mathf.Abs(horizontalInput));
        animatorManager.UpdateAnimatorValues(0,moveAmount);
    }


    private void HandleCameraInput()
    {
        cameraInputX = cameraInput.x;
        cameraInputY = cameraInput.y;


    }


}
