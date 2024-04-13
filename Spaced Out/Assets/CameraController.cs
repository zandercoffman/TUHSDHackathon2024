using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the speed of camera movement
    public float rotationSpeed = 100f; // Adjust this value to control the speed of camera rotation

    private float mouseX, mouseY;

    void Update()
    {
        // Camera Movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Camera Rotation
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Limit vertical rotation to prevent flipping

        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
    }
}
