using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody body;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.W)) {
            h = 1f;
        } else if (Input.GetKey(KeyCode.A)) {
            v = -1f;
        } else if (Input.GetKey(KeyCode.S)) {
            h = -1f;
        } else if (Input.GetKey(KeyCode.D)) {
            v = 1f;
        }
        body.velocity = new Vector2(h * speed, v * speed);
    }
}
