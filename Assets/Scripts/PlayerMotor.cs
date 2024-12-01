using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float jumpHeight = 3f;
    
    [Header("Gravity")]
    [Tooltip("Nilai default -9.81 untuk gravitasi bumi")]
    public float gravityForce = -9.81f;
    private float verticalVelocity;  // Ganti nama dari fallVelocity
    private Vector3 moveDirection;    // Tambahkan ini untuk tracking movement

    void Start()
    {
        controller = GetComponent<CharacterController>();
        verticalVelocity = 0f;
        moveDirection = Vector3.zero;
    }

    void Update()
    {
        ApplyMovement();
    }

    void ApplyMovement()
    {
        if (controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }
        else
        {
            verticalVelocity += gravityForce * Time.deltaTime;
        }

        // Kombinasikan gerakan horizontal dan vertikal
        moveDirection.y = verticalVelocity;
        
        // Aplikasikan gerakan
        controller.Move(moveDirection * Time.deltaTime);
        
        Debug.Log($"Vertical Velocity: {verticalVelocity:F2}");
    }

    public void ProcessMove(Vector2 input)
    {
        // Update gerakan horizontal
        moveDirection.x = input.x * moveSpeed;
        moveDirection.z = input.y * moveSpeed;
        
        // Transform ke arah lokal karakter
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection.y = verticalVelocity; // Pastikan vertical velocity tidak hilang
    }

    public void Jump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravityForce);
            Debug.Log($"Jump force applied: {verticalVelocity}");
        }
    }
}