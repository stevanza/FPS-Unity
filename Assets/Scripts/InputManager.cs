using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerMotor motor;
    private PlayerLook look;
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    
    private Vector2 currentMovementInput;
    private Vector2 currentLookInput; // Tambahkan variable untuk menyimpan input look

    void Awake()
    {
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        onFoot.Enable();
        
        // Movement handler
        onFoot.Movement.performed += ctx => 
        {
            currentMovementInput = ctx.ReadValue<Vector2>();
            Debug.Log($"Movement Input: {currentMovementInput}");
        };
        
        onFoot.Movement.canceled += ctx => 
        {
            currentMovementInput = Vector2.zero;
            Debug.Log("Movement stopped");
        };
        
        // Look handler
        onFoot.Look.performed += ctx =>
        {
            currentLookInput = ctx.ReadValue<Vector2>();
            Debug.Log($"Look Input: {currentLookInput}");
        };
        
        onFoot.Look.canceled += ctx =>
        {
            currentLookInput = Vector2.zero;
            Debug.Log("Look stopped");
        };
        
        // Jump handler
        onFoot.Jump.performed += _ => 
        {
            if(motor != null)
            {
                motor.Jump();
                Debug.Log("Jump triggered");
            }
        };
        
        Debug.Log("InputManager initialized");
    }

    void OnDestroy()
    {
        onFoot.Disable();
        playerInput.Dispose();
    }

    void Update()
    {
        // Handle movement
        motor?.ProcessMove(currentMovementInput);
    }

    void LateUpdate()
    {
        // Handle looking - perbaikan dari ProcessMove ke ProcessLook
        look?.ProcessLook(currentLookInput);
    }
}