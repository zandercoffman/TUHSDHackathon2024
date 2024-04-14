using UnityEngine;

public class PlanetPlayerMovement : MonoBehaviour
{
public float speed = 20;
private Vector3 motion;
private Rigidbody rb;

static Quaternion generateQuaterion(string direction)
{
    float tiltAngle = float.MaxValue;

    if (direction=="left") 
    {
        tiltAngle = float.MinValue;
    }

    float tiltAroundY = tiltAngle;

    Quaternion target = Quaternion.Euler(0, tiltAroundY, 0);

    return target;
}
void Start()
{
rb = GetComponent<Rigidbody>();
}

void Update()
{
motion = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));	
rb.velocity = motion * speed;

if (Input.GetKey(KeyCode.E))
 {
    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("right"), Time.deltaTime * 5.0f);
 }
 else if (Input.GetKey(KeyCode.Q)) {
    rb.rotation = Quaternion.Slerp(rb.rotation, generateQuaterion("left"), Time.deltaTime * 5.0f);
 }
}
}