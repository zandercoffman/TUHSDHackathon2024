using UnityEngine;
using System;

public class PlayerMovement3D : MonoBehaviour
{
public float speed = 20;
private Vector3 motion;
private Rigidbody rb;
private int firstTimesRun = 100;

static Quaternion generateQuaterion(string direction)
{
    float tiltAngle = 180f;

    if (direction=="left") 
    {
        tiltAngle = -180f;
    }

    float tiltAroundY = tiltAngle;

    Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);

    return target;
}
void Start()
{
rb = GetComponent<Rigidbody>();
rb.rotation = Quaternion.Euler(0,0,0);
}

void Update()
{
    float horiz = Input.GetAxisRaw("Horizontal");
    float vert = Input.GetAxisRaw("Vertical");
    float angle = rb.rotation.eulerAngles[1];
    Debug.Log(angle);

motion = Quaternion.Euler(0, angle, 0) * new Vector3(horiz, 0, vert);	
rb.velocity = motion * speed;

//if (Input.GetKey(KeyCode.E))
// {
//    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("right"), Time.deltaTime * 5.0f);
// }
// else if (Input.GetKey(KeyCode.Q)) {
//    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("left"), Time.deltaTime * 5.0f);
// }

if (firstTimesRun>0)
{
    rb.rotation = Quaternion.Euler(0,0,0);
    firstTimesRun--;
}
else
{
rb.rotation *= Quaternion.Euler(-1*Input.GetAxis("Mouse Y")*5, Input.GetAxis("Mouse X")*5, 0);
}

}
}