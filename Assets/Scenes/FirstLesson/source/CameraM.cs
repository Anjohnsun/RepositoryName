using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraM  : MonoBehaviour
{
    [SerializeField] private Transform objToFollow;

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        transform.position = Vector3.Lerp(transform.position, objToFollow.position, 0.02f);
        transform.rotation = Quaternion.Lerp(transform.rotation, objToFollow.rotation, 0.15f);
    }
}
