using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

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

//set the speed to be much faster if the player is traveling between planets
    if (SceneManager.GetActiveScene().name=="Big")
    {
        speed = 50;
    }
}

void Update()
{
    //get horizontal and forwardBack input (uses wasd)
    float horiz = Input.GetAxisRaw("Horizontal");
    float forwardBack = Input.GetAxisRaw("Vertical");

    //prevent the space shuttle from flying sideways or backwards
    if (SceneManager.GetActiveScene().name=="Big")
    {
        horiz = 0;
        if (forwardBack<0)
        {
            forwardBack=0;
        }
    }
//figure out the direction of motion and magnitude using a vector created using the input rotated by a quaternion representing the player rotation
motion = rb.rotation * new Vector3(horiz, 0, forwardBack);	

//scale the vector by the player speed
rb.velocity = motion * speed;

//if (Input.GetKey(KeyCode.E))
// {
//    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("right"), Time.deltaTime * 5.0f);
// }
// else if (Input.GetKey(KeyCode.Q)) {
//    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("left"), Time.deltaTime * 5.0f);
// }


//check if this is one of the first 100 times this has run (if this executes normally for the first few times the rotation gets messed up and rotated incorrectly for some reason, maybe the mouse position change is too big because it jumps from 0,0 to the real coordinates?)
if (firstTimesRun>0)
{
    //if so set the rotation to zero and decrement the counter
    rb.rotation = Quaternion.Euler(0,0,0);
    firstTimesRun--;
}
else
{
    //otherwise apply normal rotation using a quaternion
    rb.rotation *= Quaternion.Euler(-1*Input.GetAxis("Mouse Y")*5, Input.GetAxis("Mouse X")*5, 0);

    //set the z component of the roation to be zero, the camera should never be tilted along z
    rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles[0], rb.rotation.eulerAngles[1], 0);
}

}
}