using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam; // Perbaikan: 'camera' -> 'Camera'
    private float xRotation = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input) // Perbaikan: 'vector2' -> 'Vector2'
    {
        float mouseX = input.x;
        float mouseY = input.y;
        
        // Calculate camera rotation for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity; // Perbaikan: 'deltaTIme' -> 'deltaTime'
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        
        // Apply to camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        
        // Rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity); // Perbaikan: 'trasnfer' -> 'transform'
    }
}