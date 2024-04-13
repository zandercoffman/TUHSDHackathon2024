using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        
    }

    public float moveSpeed = 5f; // Adjust this value to control the speed of camera movement
    public float rotationSpeed = 100f; // Adjust this value to control the speed of camera rotation

    void Update()
    {
        // Camera Movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Camera Rotation (Optional)
        float rotateInput = Input.GetAxis("Rotation");
        transform.Rotate(Vector3.up, rotateInput * rotationSpeed * Time.deltaTime);
    }
}
