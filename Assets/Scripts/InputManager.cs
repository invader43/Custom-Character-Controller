using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    [SerializeField] public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;
    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
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
        //Other Inputs get called here
    }
    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
