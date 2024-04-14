using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    [Header("Move Speed")]
    public float moveSpeed = 10f;

    [Header("Default Rotation Speed")]
    public float rotateSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);

        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
}
