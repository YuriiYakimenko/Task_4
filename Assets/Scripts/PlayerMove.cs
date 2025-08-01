using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private WheelJoint2D wheel;
    private JointMotor2D motor;
    public float speed;

    void Start()
    {
        wheel = GetComponent<WheelJoint2D>();
        motor = wheel.motor; 
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        motor.motorSpeed = speed * horizontalForce;
        wheel.motor = motor;
    }
}
