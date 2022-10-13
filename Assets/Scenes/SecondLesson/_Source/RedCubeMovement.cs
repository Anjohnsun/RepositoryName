using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeMovement : MonoBehaviour
{
    [SerializeField] private HingeJoint hJoint;
    [SerializeField] private JointMotor motor;

    private void Start()
    {
        motor = hJoint.motor;
    }
    void Update()
    {
        if (transform.rotation.y < 0 && transform.localRotation.y > -0.05)
        {
            motor.targetVelocity = 120;
            hJoint.motor = motor;
        }
        if (transform.rotation.y > -1 && transform.rotation.y < -0.95)
        {
            motor.targetVelocity = -120;
            hJoint.motor = motor;
        }
    }
}
