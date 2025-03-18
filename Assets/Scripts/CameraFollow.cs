using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform; // The car's transform
    public Vector3 offset; // The offset from the car to the camera
    public float smoothSpeed = 0.125f; // How smooth the camera movement is

    void Start()
    {
        // Optionally, set the initial offset if you haven't already
        offset = transform.position - carTransform.position;
    }

    void LateUpdate()
    {
        // Calculate the desired position of the camera
        Vector3 desiredPosition = carTransform.position + offset;

        // Smoothly move the camera to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Set the camera position
        transform.position = smoothedPosition;

        // Optionally, make the camera always look at the car
        transform.LookAt(carTransform);
    }
}
