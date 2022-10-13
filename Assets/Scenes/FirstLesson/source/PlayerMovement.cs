using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerMovement
{
    public static void Move(Rigidbody rb, float arrowValue, float Speed)
    {
        rb.AddForce(rb.transform.forward * arrowValue * Speed);
    }
    public static void Rotate(Rigidbody rb, float arrowValue, float RotationSpeed)
    {
       rb.AddTorque(new Vector3(0, arrowValue*RotationSpeed, 0), ForceMode.Acceleration);
    }
    public static void Jump(Rigidbody rb, float JumpForce)
    {
        rb.AddForce(Vector3.up*JumpForce, ForceMode.Impulse);
    }
}
