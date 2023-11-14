using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2.0f; // Adjust the sensitivity of the camera movement

    private float mouseX, mouseY;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        // Get mouse movement
        mouseX = Input.GetAxis("Mouse X") * sensitivity;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Adjust the camera rotation based on mouse input
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f); // Limit vertical rotation to avoid flipping

        rotationY += mouseX;

        // Apply rotation to the camera
        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
    }
}
