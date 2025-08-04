using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private WheelJoint2D[] wheels;
    public float speed;

    private float _horizontalForce;

    void Start()
    {
        wheels = GetComponents<WheelJoint2D>();
    }

    private void Update()
    {
        _horizontalForce = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        for (int i = 0; i < wheels.Length; i++)
        {
            var wheel = wheels[i];
            var motor = wheel.motor;
            motor.motorSpeed = -speed * _horizontalForce;
            wheel.motor = motor;
        }
    }
}